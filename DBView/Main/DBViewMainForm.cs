using System;
using System.Windows.Forms;
using DBView.Dialogs;
using DBView.DTO;

namespace DBView.Main
{
    public partial class DBViewMainForm : Form
    {
        private TreeViewFindDialog treeViewFindDialog;

        public DBViewMainForm()
        {
            InitializeComponent();
            HookEvents();
            dbViewTreeView.QueryTabs = queryTabs;
            dbViewTreeView.ListDatabases();
            InitTreeViewFindDialog();
        }

        private void InitTreeViewFindDialog()
        {
            var location = Location;
            location.X += 50;
            location.Y += 50;
            treeViewFindDialog = new TreeViewFindDialog(location);
        }

        private void HookEvents()
        {
            newConnectionMenuItem.Click += connectMenuItem_Click;
        }

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            var connectDialog = new ConnectDialog();
            var dialogResult = connectDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            dbViewTreeView.AddConnection(connectDialog.DbProvider);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (!dbViewTreeView.Focused) return;
            if (e.Control && e.KeyCode == Keys.F) ShowFindTreeViewDialog(new FindDetails());
            else if (e.Shift && e.KeyCode == Keys.F3) dbViewTreeView.Find(false);
            else if (e.KeyCode == Keys.F3) dbViewTreeView.Find(true);
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFindTreeViewDialog(new FindDetails {FindPkgs = false, FindViews = false});
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFindTreeViewDialog(new FindDetails { FindTables = false, FindViews = false });
        }

        private void viewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFindTreeViewDialog(new FindDetails { FindTables = false, FindPkgs = false });
        }

        private void ShowFindTreeViewDialog(FindDetails findDetails)
        {
            treeViewFindDialog.FindDetails = findDetails;
            var dialogResult = treeViewFindDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            dbViewTreeView.Find(treeViewFindDialog.FindDetails);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}