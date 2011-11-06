using System.Drawing;
using System.Windows.Forms;
using DBView.DTO;

namespace DBView.Dialogs
{
    public partial class TreeViewFindDialog : Form
    {
        private FindDetails findDetails;

        public TreeViewFindDialog(Point location)
        {
            InitializeComponent();
            Location = location;
            findDetails = new FindDetails();
            HookEvents();
        }

        public FindDetails FindDetails
        {
            get { return findDetails; }
            set
            {
                findDetails = value;
                BindData();
            }
        }

        private void HookEvents()
        {
            findTextBox.TextChanged += delegate { EnableDisableFindButton(); };
            tablesCheckBox.CheckedChanged += delegate { EnableDisableFindButton(); };
            pkgsCheckBox.CheckedChanged += delegate { EnableDisableFindButton(); };
            viewsCheckBox.CheckedChanged += delegate { EnableDisableFindButton(); };
        }

        private void BindData()
        {
            findTextBox.DataBindings.Clear();
            findTextBox.DataBindings.Add("Text", FindDetails, "FindStr", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            tablesCheckBox.DataBindings.Clear();
            tablesCheckBox.DataBindings.Add("Checked", FindDetails, "FindTables", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            pkgsCheckBox.DataBindings.Clear();
            pkgsCheckBox.DataBindings.Add("Checked", FindDetails, "FindPkgs", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            viewsCheckBox.DataBindings.Clear();
            viewsCheckBox.DataBindings.Add("Checked", FindDetails, "FindViews", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            matchWholeWordCheckBox.DataBindings.Clear();
            matchWholeWordCheckBox.DataBindings.Add("Checked", FindDetails, "MatchWholeString", true).
                DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            matchCaseCheckBox.DataBindings.Clear();
            matchCaseCheckBox.DataBindings.Add("Checked", FindDetails, "MatchCase", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;
        }

        private void EnableDisableFindButton()
        {
            findNextButton.Enabled = !string.IsNullOrEmpty(findTextBox.Text) &&
                                     (tablesCheckBox.Checked || pkgsCheckBox.Checked || viewsCheckBox.Checked);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter && findNextButton.Enabled) DialogResult = DialogResult.OK;
        }
    }
}