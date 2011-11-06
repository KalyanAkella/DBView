using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DBView.Controls
{
    public partial class AutoCompleteDropDown : ListBox
    {
        public event EventHandler<WordSelectedEventArgs> WordSelected = delegate { };
        public event EventHandler<WordSelectedEventArgs> WordReplaced = delegate { };

        public AutoCompleteDropDown()
        {
            InitializeComponent();
        }

        public void ShowDropDown(IList<string> tables, Point position)
        {
            BeginUpdate();
            DataSource = tables;
            position.Y += FontHeight;
            Location = position;
            Width = (int) (RetrieveMaxSize(tables)*Font.SizeInPoints);
            EndUpdate();
            Visible = true;
            Focus();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return keyData == Keys.Tab || keyData == Keys.Escape || keyData == Keys.Up || keyData == Keys.Down ||
                   keyData == Keys.Enter;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Hide();
            else if (e.KeyCode == Keys.Up)
            {
                if (SelectedIndex == 0) SelectedIndex = Items.Count - 1;
                else SelectedIndex--;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (SelectedIndex == Items.Count - 1) SelectedIndex = 0;
                else SelectedIndex++;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Hide();
                WordSelected(this, new WordSelectedEventArgs((string) SelectedItem));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                Hide();
                WordReplaced(this, new WordSelectedEventArgs((string) SelectedItem));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private static int RetrieveMaxSize(IEnumerable<string> tables)
        {
            var maxSize = -1;
            foreach (var table in tables) maxSize = Math.Max(maxSize, table.Length);
            return maxSize;
        }
    }

    public class WordSelectedEventArgs : EventArgs
    {
        private readonly string selectedWord;

        public WordSelectedEventArgs(string selectedWord)
        {
            this.selectedWord = selectedWord;
        }

        public string SelectedWord
        {
            get { return selectedWord; }
        }
    }
}