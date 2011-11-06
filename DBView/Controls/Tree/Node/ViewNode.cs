using System;
using System.Windows.Forms;
using DBView.DB.Provider;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class ViewNode : AbstractDBNode
    {
        public ViewNode(string viewName) : base(viewName, NodeType.VIEW)
        {
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
                currentNode = (ViewNode) dbNode;
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
                currentNode = (ViewNode) dbNode;
            }
            return nodeFound;
        }

        public override bool UpdateContextMenu(ContextMenuStrip contextMenuStrip)
        {
            base.UpdateContextMenu(contextMenuStrip);
            var openViewMenuItem = ContextMenuItem.OpenView();
            openViewMenuItem.Click += openViewMenuItem_Click;
            contextMenuStrip.Items.Add(openViewMenuItem);
            return true;
        }

        private void openViewMenuItem_Click(object sender, EventArgs e)
        {
            var openViewTab = new TabPage(Text);
            var dbViewProvider = (IDBViewProvider) ConnectionNode.Tag;
            var queryBoxControl = new QueryBoxControl(dbViewProvider)
                                      {
                                          Dock = DockStyle.Fill,
                                          Text = dbViewProvider.RetreiveViewBody(Text)
                                      };
            openViewTab.Controls.Add(queryBoxControl);
            ConnectionNode.QueryTabs.TabPages.Add(openViewTab);
            ConnectionNode.QueryTabs.SelectTab(openViewTab);
        }

        private ConnectionNode ConnectionNode
        {
            get { return (ConnectionNode) Parent.Parent; }
        }
    }
}