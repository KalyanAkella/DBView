using System;
using System.Windows.Forms;
using DBView.DTO;

namespace DBView.Dialogs.DBDialogs
{
    public partial class SqlServerDBDialog : UserControl, IDBDialog
    {
        private readonly ConnectionDetail connectionDetail = new ConnectionDetail();

        public event EventHandler DataAvailable;
        public event EventHandler DataUnAvailable;

        public SqlServerDBDialog()
        {
            InitializeComponent();
            BindData();
            HookEvents();
        }

        private void HookEvents()
        {
            cdConnNameTextBox.TextChanged += TextBox_TextChanged;
            cdServerNameTextBox.TextChanged += TextBox_TextChanged;
            cdDatabaseTextBox.TextChanged += TextBox_TextChanged;
            cdUserNameTextBox.TextChanged += TextBox_TextChanged;
            cdPasswordTextBox.TextChanged += TextBox_TextChanged;
            cdAuthTypeCombo.SelectedIndexChanged += AuthType_SelectedIndexChanged;
        }

        private void BindData()
        {
            connectionDetail.DBType = DBType.SqlServer;

            cdServerNameTextBox.DataBindings.Clear();
            cdServerNameTextBox.DataBindings.Add("Text", connectionDetail, "DataSourceName", true).DataSourceUpdateMode
                = DataSourceUpdateMode.OnPropertyChanged;

            cdConnNameTextBox.DataBindings.Clear();
            cdConnNameTextBox.DataBindings.Add("Text", connectionDetail, "ConnName", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            cdDatabaseTextBox.DataBindings.Clear();
            cdDatabaseTextBox.DataBindings.Add("Text", connectionDetail, "InitialCatalog", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;

            cdUserNameTextBox.DataBindings.Clear();
            cdUserNameTextBox.DataBindings.Add("Text", connectionDetail, "UserName", true).DataSourceUpdateMode = 
                DataSourceUpdateMode.OnPropertyChanged;

            cdPasswordTextBox.DataBindings.Clear();
            cdPasswordTextBox.DataBindings.Add("Text", connectionDetail, "PassWord", true).DataSourceUpdateMode = 
                DataSourceUpdateMode.OnPropertyChanged;

            cdAuthTypeCombo.SelectedIndex = 0;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cdServerNameTextBox.Text) && !string.IsNullOrEmpty(cdConnNameTextBox.Text) &&
                !string.IsNullOrEmpty(cdDatabaseTextBox.Text) && IsTextValid(cdUserNameTextBox) &&
                IsTextValid(cdPasswordTextBox))
                DataAvailable(this, new EventArgs());
            else DataUnAvailable(this, new EventArgs());
        }

        private void AuthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cdUserNameTextBox.Enabled = cdPasswordTextBox.Enabled = cdAuthTypeCombo.SelectedIndex != 0;
            connectionDetail.AuthType = (AuthType) cdAuthTypeCombo.SelectedIndex;
            TextBox_TextChanged(sender, e);
        }

        public ConnectionDetail ConnectionDetail
        {
            get { return connectionDetail; }
        }

        private static bool IsTextValid(Control textBox)
        {
            return !textBox.Enabled || (textBox.Enabled && !string.IsNullOrEmpty(textBox.Text));
        }
    }
}