using System;
using System.Windows.Forms;
using DBView.DB;
using DBView.DB.Provider;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class ConnectionNode : AbstractDBNode
    {
        public TabControl QueryTabs { get; set; }
        private QueryTabPage queryPage;

        public ConnectionNode(ConnectionDetail connectionDetail, TabControl queryTabs) : base(connectionDetail.ConnName)
        {
            QueryTabs = queryTabs;
            Tag = connectionDetail;
        }

        public ConnectionNode(IDBViewProvider dbViewProvider, TabControl queryTabs) : base(dbViewProvider.ConnectionDetail.ConnName)
        {
            QueryTabs = queryTabs;
            Tag = dbViewProvider;
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }

        public override bool FindNext(FindDetails findDetails)
        {
            if (!IsConnectionOpen) return false;
            var nodeFound = false;
            if (findDetails.FindTables)
            {
                var tablesNode = (IDBNode) Nodes[0];
                nodeFound = tablesNode.FindNext(findDetails);
            }
            if (findDetails.FindPkgs && !nodeFound)
            {
                var pkgsNode = (IDBNode) Nodes[1];
                nodeFound = pkgsNode.FindNext(findDetails);
            }
            if (findDetails.FindViews && !nodeFound)
            {
                var viewsNode = (IDBNode) Nodes[2];
                nodeFound = viewsNode.FindNext(findDetails);
            }
            return nodeFound;
        }

        public override bool FindPrevious(FindDetails findDetails)
        {
            if (!IsConnectionOpen) return false;
            var nodeFound = false;
            if (findDetails.FindViews)
            {
                var tablesNode = (IDBNode) Nodes[2];
                nodeFound = tablesNode.FindPrevious(findDetails);
            }
            if (findDetails.FindPkgs && !nodeFound)
            {
                var pkgsNode = (IDBNode) Nodes[1];
                nodeFound = pkgsNode.FindPrevious(findDetails);
            }
            if (findDetails.FindTables && !nodeFound)
            {
                var viewsNode = (IDBNode) Nodes[0];
                nodeFound = viewsNode.FindPrevious(findDetails);
            }
            return nodeFound;
        }

        public override bool UpdateContextMenu(ContextMenuStrip contextMenuStrip)
        {
            base.UpdateContextMenu(contextMenuStrip);
            var connectMenuItem = ContextMenuItem.Connect(!IsConnectionOpen);
            connectMenuItem.Click += connectMenuItem_Click;
            contextMenuStrip.Items.Add(connectMenuItem);

            var disconnectMenuItem = ContextMenuItem.Disconnect(IsConnectionOpen);
            disconnectMenuItem.Click += disconnectMenuItem_Click;
            contextMenuStrip.Items.Add(disconnectMenuItem);

            var refreshMenuItem = ContextMenuItem.Refresh(IsConnectionOpen);
            refreshMenuItem.Click += refreshMenuItem_Click;
            contextMenuStrip.Items.Add(refreshMenuItem);

            var deleteMenuItem = ContextMenuItem.Delete(!IsConnectionOpen);
            deleteMenuItem.Click += deleteMenuItem_Click;
            contextMenuStrip.Items.Add(deleteMenuItem);
            return true;
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            DBUtil.DeleteConnection((ConnectionDetail) Tag);
            Remove();
        }

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            var dbViewProvider = (IDBViewProvider) Tag;
            dbViewProvider.ResetContents();
            ConstructChildren();
        }

        private bool IsConnectionOpen
        {
            get { return Tag is IDBViewProvider; }
        }

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tag = DBViewProviderFactory.RetrieveDbProvider((ConnectionDetail) Tag);
                ConstructChildren();
                ConstructQueryPage();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {
            Nodes.Clear();
            var dbViewProvider = ((IDBViewProvider) Tag);
            dbViewProvider.Close();
            QueryTabs.DeselectTab(queryPage);
            QueryTabs.TabPages.Remove(queryPage);
            Tag = dbViewProvider.ConnectionDetail;
        }

        public void ConstructChildren()
        {
            if (!IsConnectionOpen) return;
            var dbViewProvider = ((IDBViewProvider) Tag);

            TreeView.BeginUpdate();
            Nodes.Clear();
            var tablesNode = new TablesNode();
            Nodes.Add(tablesNode);
            dbViewProvider.AllTableNames.ForEach(tableName => tablesNode.Nodes.Add(new TableNode(tableName)));

            var pkgsNode = new PackagesNode();
            Nodes.Add(pkgsNode);
            dbViewProvider.AllPackageNames.ForEach(packageName => pkgsNode.Nodes.Add(new PackageNode(packageName)));

            var viewsNode = new ViewsNode();
            Nodes.Add(viewsNode);
            dbViewProvider.AllViewNames.ForEach(viewName => viewsNode.Nodes.Add(new ViewNode(viewName)));
            TreeView.EndUpdate();
        }

        public void ConstructQueryPage()
        {
            if (!IsConnectionOpen) return;
            var dbViewProvider = ((IDBViewProvider) Tag);

            queryPage = new QueryTabPage(dbViewProvider);
            QueryTabs.TabPages.Add(queryPage);
            QueryTabs.SelectTab(queryPage);
        }
    }
}