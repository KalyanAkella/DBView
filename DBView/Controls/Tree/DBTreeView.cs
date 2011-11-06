using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DBView.Controls.Tree.Node;
using DBView.DB;
using DBView.DB.Provider;
using DBView.DTO;

namespace DBView.Controls.Tree
{
    public partial class DBTreeView : TreeView
    {
        private TreeNode rootNode;
        private FindDetails recentFindDetails;
        private TabControl queryTabs;

        public DBTreeView()
        {
            InitializeComponent();
            treeViewContextMenu.Opening += treeViewContextMenu_Opening;
        }

        public void ListDatabases()
        {
            BeginUpdate();
            Nodes.Clear();
            var connectionsNode = RetreiveConnectionsNode();
            connectionsNode.Expand();
            rootNode = connectionsNode;
            Nodes.Add(rootNode);
            TopNode = rootNode;
            EndUpdate();
        }

        protected override void OnBeforeCollapse(TreeViewCancelEventArgs e)
        {
            base.OnBeforeCollapse(e);
            if (e.Node is ConnectionsNode) e.Cancel = true;
        }

        private ConnectionsNode RetreiveConnectionsNode()
        {
            var connectionsNode = new ConnectionsNode();
            var recentConnections = DBUtil.RecentConnections();
            if (recentConnections != null)
                foreach (var recentConnection in recentConnections)
                    connectionsNode.Nodes.Add(new ConnectionNode(recentConnection, queryTabs));
            return connectionsNode;
        }

        public TabControl QueryTabs
        {
            set { queryTabs = value; }
        }

        public void AddConnection(IDBViewProvider dbViewProvider)
        {
            BeginUpdate();
            var connectionNode = new ConnectionNode(dbViewProvider, queryTabs);
            TopNode.Nodes.Add(connectionNode);
            connectionNode.ConstructChildren();
            connectionNode.ConstructQueryPage();
            EndUpdate();
            TopNode.Expand();
            connectionNode.EnsureVisible();
        }

        public void Find(FindDetails findDetails)
        {
            recentFindDetails = findDetails;
            var dbNode = (IDBNode) rootNode;
            var nodeFound = dbNode.FindNext(findDetails);
            if (!nodeFound)
                MessageBox.Show("Unable to find the specified DB element", "Find", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
        }

        public void Find(bool next)
        {
            if (recentFindDetails == null) return;
            var currentNode = (IDBNode) SelectedNode;
            if (currentNode == null || currentNode == rootNode) Find(recentFindDetails);
            else
            {
                var nodeFound = false;
                while (!nodeFound && currentNode != null)
                {
                    nodeFound = next
                                    ? currentNode.FindNext(recentFindDetails)
                                    : currentNode.FindPrevious(recentFindDetails);
                    if (!nodeFound)
                        currentNode = next
                                          ? (IDBNode) ((TreeNode) currentNode).Parent.NextNode
                                          : (IDBNode) ((TreeNode) currentNode).Parent.PrevNode;
                }
            }
        }

        protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
        {
            var dbNode = (IDBNode) e.Node;
            if (!dbNode.HasDBNodesAsChildren) return;
            BeginUpdate();
            dbNode.BeginExpand();
            EndUpdate();
            ExpandBackgroundWorker.RunWorkerAsync(dbNode);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button != MouseButtons.Right) return;
            var point = new Point(e.X, e.Y);
            var treeNode = GetNodeAt(point);
            if (treeNode != null) SelectedNode = treeNode;
        }

        protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
        {
            base.OnNodeMouseClick(e);
            if (e.Button != MouseButtons.Right) return;
            e.Node.ContextMenuStrip = treeViewContextMenu;
            treeViewContextMenu.Show();
        }

        private void ExpandCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BeginUpdate();
            if (e.Error != null) MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var resultsDTO = (ResultsDTO) e.Result;
                resultsDTO.DbNode.FinishExpand(resultsDTO.ChildNodeNames);
            }
            EndUpdate();
        }

        private BackgroundWorker ExpandBackgroundWorker
        {
            get
            {
                var expandBackgroundWorker = new BackgroundWorker();
                expandBackgroundWorker.DoWork +=
                    ((sender, e) => { e.Result = new ResultsDTO((IDBNode) e.Argument, ((IDBNode) e.Argument).ProcessExpand()); });
                expandBackgroundWorker.RunWorkerCompleted += ExpandCompleted;
                return expandBackgroundWorker;
            }
        }

        private void treeViewContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (SelectedNode == null) e.Cancel = true;
            else e.Cancel = !((IDBNode) SelectedNode).UpdateContextMenu(treeViewContextMenu);
        }
    }
}