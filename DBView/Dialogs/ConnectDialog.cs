using System.ComponentModel;
using System.Windows.Forms;
using DBView.DB;
using DBView.DB.Provider;
using DBView.Dialogs.DBDialogs;
using DBView.DTO;

namespace DBView.Dialogs
{
    public partial class ConnectDialog : Form
    {
        private BackgroundWorker backgroundWorker;

        public ConnectDialog()
        {
            InitializeComponent();
            InitBackgroundWorker();
            ListSupportedDatabases();
            HookEvents();
        }

        private void InitBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker {WorkerSupportsCancellation = true};
            backgroundWorker.DoWork += DoConnect;
        }

        private void ListSupportedDatabases()
        {
            dbServers.BeginUpdate();
            dbServers.Nodes.Clear();
            var supportedDatabasesNode = RetrieveSupportedDatabasesList();
            dbServers.Nodes.Add(supportedDatabasesNode);
            dbServers.SelectedNode = supportedDatabasesNode.Nodes[0];
            dbServers.EndUpdate();
        }

        private void HookEvents()
        {
            dbServers.AfterSelect += dbServers_AfterSelect;
            cdConnectButton.Click += delegate { SetUp("Connecting...", ConnectCompleted); };
            cdTestButton.Click += delegate { SetUp("Testing...", TestConnectCompleted); };
        }

        private static void DoConnect(object sender, DoWorkEventArgs e)
        {
            e.Result = DBViewProviderFactory.RetrieveDbProvider((ConnectionDetail) e.Argument);
        }

        private void ConnectCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cdDialogPanel.Enabled = true;
            cdConnectButton.Enabled = true;
            cdTestButton.Enabled = true;
            if (e.Error != null) cdConnectStatusLabel.Text = e.Error.Message;
            else
            {
                DbProvider = (IDBViewProvider) e.Result;
                cdConnectStatusLabel.Text = "Connection successful!";
                DBUtil.SaveConnection(DbProvider.ConnectionDetail);
                DialogResult = DialogResult.OK;
            }
            backgroundWorker.RunWorkerCompleted -= ConnectCompleted;
        }

        private void TestConnectCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cdDialogPanel.Enabled = true;
            cdConnectButton.Enabled = true;
            cdTestButton.Enabled = true;
            if (e.Error != null) cdConnectStatusLabel.Text = e.Error.Message;
            else
            {
                var dbViewProvider = (IDBViewProvider) e.Result;
                if (dbViewProvider != null) dbViewProvider.Close();
                cdConnectStatusLabel.Text = "Connection successful!";
            }
            backgroundWorker.RunWorkerCompleted -= TestConnectCompleted;
        }

        public IDBViewProvider DbProvider { get; private set; }

        private void SetUp(string statusText, RunWorkerCompletedEventHandler workerCompletedTask)
        {
            cdDialogPanel.Enabled = false;
            cdConnectButton.Enabled = false;
            cdTestButton.Enabled = false;
            cdConnectStatusLabel.Text = statusText;
            backgroundWorker.RunWorkerCompleted += workerCompletedTask;
            backgroundWorker.RunWorkerAsync(ConnectionDetail);
        }

        public ConnectionDetail ConnectionDetail
        {
            get { return ((IDBDialog) cdDialogPanel.Controls[0]).ConnectionDetail; }
        }

        private void dbServers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;
            cdDialogPanel.SuspendLayout();
            var dialog = DBDialogFactory.GetDBDialog(((DBType)e.Node.Tag));
            dialog.DataAvailable += delegate { SetEnabledFlagForConnectTestButtons(true); };
            dialog.DataUnAvailable += delegate { SetEnabledFlagForConnectTestButtons(false); };
            cdDialogPanel.Controls.Clear();
            cdDialogPanel.Controls.Add((Control) dialog);
            cdDialogPanel.Size = ((Control) dialog).Size;
            cdDialogPanel.ResumeLayout(false);
        }

        private static TreeNode RetrieveSupportedDatabasesList()
        {
            var parentNode = new TreeNode("Database Type");
            foreach (var db in DBUtil.SupportedDBList())
            {
                var dbViewDBType = (DBType) db;
                parentNode.Nodes.Add(new TreeNode(dbViewDBType.ToString()) {Tag = dbViewDBType});
            }
            parentNode.Expand();
            return parentNode;
        }

        private void SetEnabledFlagForConnectTestButtons(bool areEnabled)
        {
            cdTestButton.Enabled = areEnabled;
            cdConnectButton.Enabled = areEnabled;
        }
    }
}