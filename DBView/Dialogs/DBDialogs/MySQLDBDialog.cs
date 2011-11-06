using System;
using System.Windows.Forms;
using DBView.DTO;

namespace DBView.Dialogs.DBDialogs
{
    public partial class MySQLDBDialog : UserControl, IDBDialog
    {
        private ConnectionDetail connectionDetail = new ConnectionDetail();

        public event EventHandler DataAvailable;
        public event EventHandler DataUnAvailable;

        public MySQLDBDialog()
        {
            InitializeComponent();
            BindData();
            HookEvents();
        }

        private void HookEvents()
        {
            cdConnNameTextBox.TextChanged += TextBox_TextChanged;
            cdServerNameTextBox.TextChanged += TextBox_TextChanged;
            cdUserNameTextBox.TextChanged += TextBox_TextChanged;
            cdPasswordTextBox.TextChanged += TextBox_TextChanged;
            cdDatabaseTextBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cdServerNameTextBox.Text) && !string.IsNullOrEmpty(cdUserNameTextBox.Text) &&
                !string.IsNullOrEmpty(cdPasswordTextBox.Text) && !string.IsNullOrEmpty(cdConnNameTextBox.Text) &&
                !string.IsNullOrEmpty(cdDatabaseTextBox.Text))
                DataAvailable(this, new EventArgs());
            else DataUnAvailable(this, new EventArgs());
        }

        private void BindData()
        {
            connectionDetail.DBType = DBType.MySql;
            
            cdServerNameTextBox.DataBindings.Clear();
            cdServerNameTextBox.DataBindings.Add("Text", connectionDetail, "DataSourceName", true).DataSourceUpdateMode
                = DataSourceUpdateMode.OnPropertyChanged;
            
            cdUserNameTextBox.DataBindings.Clear();
            cdUserNameTextBox.DataBindings.Add("Text", connectionDetail, "UserName", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;
            
            cdPasswordTextBox.DataBindings.Clear();
            cdPasswordTextBox.DataBindings.Add("Text", connectionDetail, "PassWord", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;
            
            cdConnNameTextBox.DataBindings.Clear();
            cdConnNameTextBox.DataBindings.Add("Text", connectionDetail, "ConnName", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;
            
            cdDatabaseTextBox.DataBindings.Clear();
            cdDatabaseTextBox.DataBindings.Add("Text", connectionDetail, "InitialCatalog", true).DataSourceUpdateMode =
                DataSourceUpdateMode.OnPropertyChanged;
        }

        public ConnectionDetail ConnectionDetail
        {
            get { return connectionDetail; }
        }
    }
}