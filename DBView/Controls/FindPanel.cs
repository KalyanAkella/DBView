using System;
using System.Windows.Forms;

namespace DBView.Controls
{
    public partial class FindPanel : UserControl
    {
        public FindPanel()
        {
            InitializeComponent();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (!Visible) return;
            findTextBox.Focus();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            findTextBox.Focus();
        }

        public FindTextBox FindTextBox
        {
            get { return findTextBox; }
        }

        public bool IsMatchCase
        {
            get { return matchCase.Checked; }
        }

        public bool IsWholeWord
        {
            get { return wholeWord.Checked; }
        }

        public void UpdateNumberOfMatches(int numMatches)
        {
            if (numMatches == 0) findStatus.Text = "No matches found";
            else findStatus.Text = numMatches + " matches found";
        }

        public RichTextBoxFinds FindMethod()
        {
            var findMethod = RichTextBoxFinds.None;
            if (IsMatchCase) findMethod |= RichTextBoxFinds.MatchCase;
            if (IsWholeWord) findMethod |= RichTextBoxFinds.WholeWord;
            return findMethod;
        }
    }
}
