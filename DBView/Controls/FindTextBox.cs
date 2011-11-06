using System;
using System.Windows.Forms;

namespace DBView.Controls
{
    public partial class FindTextBox : TextBox
    {
        public event EventHandler FindClose = delegate { };
        public event EventHandler<FindEventArgs> Find = delegate { };

        public FindTextBox()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode != Keys.Escape && e.KeyCode != Keys.Enter) return;
            FindClose(this, e);
            e.SuppressKeyPress = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Find(this, new FindEventArgs(Text));
        }
    }

    public class FindEventArgs : EventArgs
    {
        private readonly string currentString;

        public FindEventArgs(string currentString)
        {
            this.currentString = currentString;
        }

        public string CurrentString
        {
            get { return currentString; }
        }
    }
}
