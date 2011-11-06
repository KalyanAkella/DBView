using System;
using System.Windows.Forms;
using DBView.DB.Provider;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class TableNode : AbstractDBNode
    {
        public TableNode(string tableName) : base(tableName, NodeType.TABLE)
        {
            Nodes.Add(new ColumnsNode());
            Nodes.Add(new KeysNode());
            Nodes.Add(new ConstraintsNode());
            Nodes.Add(new TriggersNode());
            Nodes.Add(new IndexesNode());
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }

        public override bool FindNext(FindDetails findDetails)
        {
            var nodeFound = false;
            var currentNode = this;
            while (!nodeFound && currentNode.NextNode != null)
            {
                var dbNode = (IDBNode) currentNode.NextNode;
                nodeFound = dbNode.DoesNodeMatch(findDetails);
                currentNode = (TableNode) dbNode;
            }
            return nodeFound;
        }

        public override bool FindPrevious(FindDetails findDetails)
        {
            var nodeFound = false;
            var currentNode = this;
            while (!nodeFound && currentNode.PrevNode != null)
            {
                var dbNode = (IDBNode) currentNode.PrevNode;
                nodeFound = dbNode.DoesNodeMatch(findDetails);
                currentNode = (TableNode) dbNode;
            }
            return nodeFound;
        }

        public override bool UpdateContextMenu(ContextMenuStrip contextMenuStrip)
        {
            base.UpdateContextMenu(contextMenuStrip);
            var openTableMenuItem = ContextMenuItem.OpenTable();
            openTableMenuItem.Click += openTableMenuItem_Click;
            contextMenuStrip.Items.Add(openTableMenuItem);
            return true;
        }

        private void openTableMenuItem_Click(object sender, EventArgs e)
        {
            var openTablePage = new TabPage(Text);
            var dataGrid = new PaginatedDataGrid(((IDBViewProvider) ConnectionNode.Tag)) {Dock = DockStyle.Fill};
            dataGrid.OpenTable(Text);
            openTablePage.Controls.Add(dataGrid);
            ConnectionNode.QueryTabs.TabPages.Add(openTablePage);
            ConnectionNode.QueryTabs.SelectTab(openTablePage);
        }

        private ConnectionNode ConnectionNode
        {
            get { return (ConnectionNode) Parent.Parent; }
        }
    }
}