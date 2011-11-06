using System;
using System.Windows.Forms;
using DBView.Dialogs;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class ConnectionsNode : AbstractDBNode
    {
        public ConnectionsNode() : base("Connections", NodeType.CONNECTIONS)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }

        public override bool UpdateContextMenu(ContextMenuStrip contextMenuStrip)
        {
            base.UpdateContextMenu(contextMenuStrip);
            var newConnectMenuItem = ContextMenuItem.NewConnection();
            newConnectMenuItem.Click += newConnectMenuItem_Click;
            contextMenuStrip.Items.Add(newConnectMenuItem);
            return true;
        }

        private void newConnectMenuItem_Click(object sender, EventArgs e)
        {
            var connectDialog = new ConnectDialog();
            var dialogResult = connectDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            ((DBTreeView) TreeView).AddConnection(connectDialog.DbProvider);
        }

        public override bool FindNext(FindDetails findDetails)
        {
            var nodeFound = false;
            foreach (var node in Nodes)
            {
                var dbNode = (IDBNode) node;
                nodeFound = dbNode.FindNext(findDetails);
                if (nodeFound) break;
            }
            return nodeFound;
        }

        public override bool FindPrevious(FindDetails findDetails)
        {
            var nodeFound = false;
            foreach (var node in NodesInReverse)
            {
                var dbNode = (IDBNode) node;
                nodeFound = dbNode.FindPrevious(findDetails);
                if (nodeFound) break;
            }
            return nodeFound;
        }
    }
}