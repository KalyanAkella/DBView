using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DBView.DB;
using DBView.DB.Provider;
using DBView.Main;

namespace DBView.Controls
{
    public partial class QueryBoxControl : RichTextBox
    {
        private readonly IDBViewProvider dbViewProvider;
        private const string WHITE_SPACE_PATTERN = @"\s+";
        public event EventHandler<QueryEventArgs> QueryExecuted = delegate { };
        private List<HashSet<string>> tableNames;
        private int maxSize = -1;
        private int recentFindIndex;
        private string recentFindTerm;
        
        //TODO: Inject this
        private readonly IMacroRepository macros = new StaticMacroRepository();

        public QueryBoxControl(IDBViewProvider dbViewProvider)
        {
            this.dbViewProvider = dbViewProvider;
            InitializeComponent();
            HookEvents();
            WordWrap = false;
            autoCompleteDropDown.Hide();
            findPanel.Hide();
        }

        private void HookEvents()
        {
            autoCompleteDropDown.WordSelected += autoCompleteDropDown_WordSelected;
            autoCompleteDropDown.WordReplaced += autoCompleteDropDown_WordReplaced;
            findPanel.FindTextBox.FindClose += (sender, e) =>
                                                   {
                                                       findPanel.Hide();
                                                       Focus();
                                                   };
            findPanel.FindTextBox.Find += findTextBox_Find;
        }

        private void FindNext()
        {
            if (string.IsNullOrEmpty(recentFindTerm)) return;
            recentFindIndex = Find(recentFindTerm, recentFindIndex + 1, RichTextBoxFinds.None);
        }

        private void findTextBox_Find(object sender, FindEventArgs e)
        {
            if (!string.IsNullOrEmpty(recentFindTerm)) HighLightOrClearMatches(recentFindTerm, Color.White);
            findPanel.UpdateNumberOfMatches(HighLightOrClearMatches(e.CurrentString, Color.Yellow));
            recentFindTerm = e.CurrentString;
        }

        private int HighLightOrClearMatches(string term, Color selectionBackColor)
        {
            var matches = 0;
            var findMethod = findPanel.FindMethod();
            var findIndex = Find(term, 0, findMethod);
            while (findIndex >= 0 && findIndex < Text.Length)
            {
                matches++;
                SelectionBackColor = selectionBackColor;
                findIndex = findIndex + SelectionLength;
                if (findIndex >= Text.Length) break;
                findIndex = Find(term, findIndex, findMethod);
            }
            recentFindIndex = Find(term, 0, findMethod);
            return matches;
        }

        public void autoCompleteDropDown_WordSelected(object sender, WordSelectedEventArgs e)
        {
            var index = GetIndexOfSpaceBackwards(SelectionStart - 1);
            SelectionLength = 0;
            Text = Text.Remove(index, SelectionStart - index);
            Text = Text.Insert(index, e.SelectedWord);
            SelectionStart = index + e.SelectedWord.Length;
        }

        private void autoCompleteDropDown_WordReplaced(object sender, WordSelectedEventArgs e)
        {
            ReplacePreviousWordWith(e.SelectedWord);
        }

        private void ReplacePreviousWordWith(string newWord)
        {
            var startIndex = GetIndexOfSpaceBackwards(SelectionStart - 1);
            var endIndex = GetIndexOfSpaceForward(SelectionStart - 1);
            var count = endIndex - startIndex;
            count = (count + 1) <= Text.Length ? count + 1 : count;
            SelectionLength = 0;
            Text = Text.Remove(startIndex, count);
            Text = Text.Insert(startIndex, newWord);
            SelectionStart = startIndex + newWord.Length;
        }

        private int GetIndexOfSpaceForward(int fromIndex)
        {
            if (string.IsNullOrEmpty(Text)) return 0;
            while (fromIndex < Text.Length && !char.IsWhiteSpace(Text[fromIndex]))
            {
                fromIndex++;
            }
            return fromIndex - 1;
        }

        private int GetIndexOfSpaceBackwards(int fromIndex)
        {
            if (string.IsNullOrEmpty(Text)) return 0;
            while (fromIndex >= 0 && !char.IsWhiteSpace(Text[fromIndex]))
            {
                fromIndex--;
            }
            return fromIndex + 1;
        }

        public void InitAutoCompletion(List<string> tables)
        {
            tableNames = new List<HashSet<string>>(26);
            for (var i = 0; i < 26; i++) tableNames.Add(new HashSet<string>());
            foreach (var tableName in tables)
            {
                var table = tableName.ToUpper();
                var tableSet = tableNames[table[0] - 'A'];
                tableSet.Add(table);
                maxSize = Math.Max(maxSize, table.Length);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 || e.KeyCode == Keys.F9) ExecuteQuery(e);
            else if (e.Control)
            {
                if (e.KeyCode == Keys.Space)
                {
                    var currentWord = CalculateCurrentWord();
                    var tables = CalculateTableNames(currentWord.Trim());
                    if (tables == null || tables.Count == 0) return;
                    autoCompleteDropDown.ShowDropDown(tables, GetPositionFromCharIndex(SelectionStart));
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                } else if (e.KeyCode == Keys.V) PasteContents(e);
                else if (e.KeyCode == Keys.F) ShowFindPanel();
            }
            else if (e.KeyCode == Keys.Space)
            {
                var currentWord = CalculateCurrentWord();
                if(macros.CanExpand(currentWord))
                {
                    ReplacePreviousWordWith(macros.GetExpansionFor(currentWord));
                }
            }
            else if (e.KeyCode == Keys.F3) FindNext();
            else if (e.KeyCode == Keys.Escape)
            {
                autoCompleteDropDown.Hide();
                findPanel.Hide();
                if (!string.IsNullOrEmpty(recentFindTerm)) HighLightOrClearMatches(recentFindTerm, Color.White);
            }
        }

        private void PasteContents(KeyEventArgs e)
        {
            Paste(DataFormats.GetFormat(DataFormats.Text));
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void ExecuteQuery(KeyEventArgs e)
        {
            var queryText = string.IsNullOrEmpty(SelectedText) ? GetTextUnderCursor() : SelectedText;
            if (!string.IsNullOrEmpty(queryText)) ExecuteQuery(queryText);
            e.Handled = true;
        }

        private void ExecuteQuery(string queryText)
        {
            var dbViewDataTable = dbViewProvider.ExecuteQuery(queryText);
            QueryExecuted(this, new QueryEventArgs(dbViewDataTable));
        }

        private void ShowFindPanel()
        {
            findPanel.Size = new Size(Size.Width, 30);
            findPanel.Location = new Point(0, 0);
            findPanel.Show();
        }

        private string GetTextUnderCursor()
        {
            var textFromFirstChar = Text.Substring(GetFirstCharIndexOfCurrentLine());
            var buffer = new StringBuilder();
            foreach (var c in textFromFirstChar)
            {
                if (Environment.NewLine.IndexOf(c) >= 0) break;
                buffer.Append(c);
            }
            return buffer.ToString();
        }

        private IList<string> CalculateTableNames(string currentWord)
        {
            return string.IsNullOrEmpty(currentWord) ? AllTableNames() : FilteredTableNames(currentWord.ToUpper());
        }

        private IList<string> AllTableNames()
        {
            return dbViewProvider.AllTableNames;
        }

        private IList<string> FilteredTableNames(string currentWord)
        {
            return dbViewProvider.RetreiveAllTableNamesLike(currentWord + "%");
        }

        private string CalculateCurrentWord()
        {
            var firstCharIndexOfCurrentLine = GetFirstCharIndexOfCurrentLine();
            var strUptoCursor = Text.Substring(firstCharIndexOfCurrentLine, SelectionStart - firstCharIndexOfCurrentLine);
            var match = Regex.Match(strUptoCursor, WHITE_SPACE_PATTERN, RegexOptions.RightToLeft);
            return match.Success ? strUptoCursor.Substring(match.Index) : strUptoCursor;
        }
    }

    public class QueryEventArgs : EventArgs
    {
        private readonly DBViewDataTable dbViewDataTable;

        public QueryEventArgs(DBViewDataTable dbViewDataTable)
        {
            this.dbViewDataTable = dbViewDataTable;
        }

        public DBViewDataTable DBViewDataTable
        {
            get { return dbViewDataTable; }
        }
    }
}