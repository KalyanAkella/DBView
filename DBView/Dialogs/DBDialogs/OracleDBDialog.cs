using System;
using System.Windows.Forms;
using DBView.DTO;

namespace DBView.Dialogs.DBDialogs
{
    public partial class OracleDBDialog : UserControl, IDBDialog
    {
        private ConnectionDetail connectionDetail = new ConnectionDetail {HostName = "localhost", PortNumber = 1521};

        public event EventHandler DataAvailable;
        public event EventHandler DataUnAvailable;

        public OracleDBDialog()
        {
            InitializeComponent();
            BindData();
            HookEvents();
        }

        private void HookEvents()
        {
            cdConnNameTextBox.TextChanged += TextBox_TextChanged;
            cdHostNameTextBox.TextChanged += TextBox_TextChanged;
            cdUserNameTextBox.TextChanged += TextBox_TextChanged;
            cdPasswordTextBox.TextChanged += TextBox_TextChanged;
            cdPortTextBox.TextChanged += TextBox_TextChanged;
            cdServiceNameTextBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cdHostNameTextBox.Text) && !string.IsNullOrEmpty(cdPortTextBox.Text) &&
                !string.IsNullOrEmpty(cdUserNameTextBox.Text) && !string.IsNullOrEmpty(cdPasswordTextBox.Text) &&
                !string.IsNullOrEmpty(cdServiceNameTextBox.Text) && !string.IsNullOrEmpty(cdConnNameTextBox.Text))
                DataAvailable(this, new EventArgs());
            else DataUnAvailable(this, new EventArgs());
        }

        private void BindData()
        {
            connectionDetail.DBType = DBType.Oracle;

            cdHostNameTextBox.DataBindings.Clear();
            cdHostNameTextBox.DataBindings.Add("Text", connectionDetail, "HostName", true).DataSourceUpdateMode
                = DataSourceUpdateMode.OnPropertyChanged;

            cdPortTextBox.DataBindings.Clear();
            cdPortTextBox.DataBindings.Add("Text", connectionDetail, "PortNumber", true).DataSourceUpdateMode
                = DataSourceUpdateMode.OnPropertyChanged;

            cdServiceNameTextBox.DataBindings.Clear();
            cdServiceNameTextBox.DataBindings.Add("Text", connectionDetail, "ServiceName", true).DataSourceUpdateMode
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
        }

        public ConnectionDetail ConnectionDetail
        {
            get { return connectionDetail; }
        }
    }
}