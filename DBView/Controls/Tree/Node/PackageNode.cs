using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBView.DB.Provider;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class PackageNode : AbstractDBNode
    {
        public PackageNode(string packageName) : base(packageName, NodeType.PKG)
        {
            Nodes.Add(new TreeNode());
        }

        public override bool HasDBNodesAsChildren
        {
            get { return true; }
        }

        public override List<string> ProcessExpandSafely()
        {
            var dbViewProvider = (IDBViewProvider) Parent.Parent.Tag;
            return dbViewProvider.RetreiveAllProcNamesForGivenPkg(NODE_NORMAL);
        }

        public override void FinishExpand(List<string> childNodeNames)
        {
            base.FinishExpand(childNodeNames);
            childNodeNames.ForEach(childNodeName => Nodes.Add(new ProcedureNode(childNodeName)));
        }

        public override bool FindNext(FindDetails findDetails)
        {
            var nodeFound = false;
            var currentNode = this;
            while (!nodeFound && currentNode.NextNode != null)
            {
                var dbNode = (IDBNode) currentNode.NextNode;
                nodeFound = dbNode.DoesNodeMatch(findDetails);
                currentNode = (PackageNode) dbNode;
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
                currentNode = (PackageNode) dbNode;
            }
            return nodeFound;
        }

        public override bool UpdateContextMenu(ContextMenuStrip contextMenuStrip)
        {
            base.UpdateContextMenu(contextMenuStrip);
            var openPkgHdrMenuItem = ContextMenuItem.OpenPackageHeader();
            openPkgHdrMenuItem.Click += openPkgHdrMenuItem_Click;
            contextMenuStrip.Items.Add(openPkgHdrMenuItem);
            var openPkgBdyMenuItem = ContextMenuItem.OpenPackageBody();
            openPkgBdyMenuItem.Click += openPkgBdyMenuItem_Click;
            contextMenuStrip.Items.Add(openPkgBdyMenuItem);
            return true;
        }

        private void openPkgHdrMenuItem_Click(object sender, EventArgs e)
        {
            var openPkgTab = new TabPage(Text + " - Header");
            var dbViewProvider = (IDBViewProvider) ConnectionNode.Tag;
            var queryBoxControl = new QueryBoxControl(dbViewProvider)
                                      {
                                          Dock = DockStyle.Fill,
                                          Text = dbViewProvider.RetreivePackageHeader(Text)
                                      };
            openPkgTab.Controls.Add(queryBoxControl);
            ConnectionNode.QueryTabs.TabPages.Add(openPkgTab);
            ConnectionNode.QueryTabs.SelectTab(openPkgTab);
        }

        private void openPkgBdyMenuItem_Click(object sender, EventArgs e)
        {
            var openPkgTab = new TabPage(Text + " - Body");
            var dbViewProvider = (IDBViewProvider) ConnectionNode.Tag;
            var queryBoxControl = new QueryBoxControl(dbViewProvider)
                                      {
                                          Dock = DockStyle.Fill,
                                          Text = dbViewProvider.RetreivePackageBody(Text)
                                      };
            openPkgTab.Controls.Add(queryBoxControl);
            ConnectionNode.QueryTabs.TabPages.Add(openPkgTab);
            ConnectionNode.QueryTabs.SelectTab(openPkgTab);
        }

        private ConnectionNode ConnectionNode
        {
            get { return (ConnectionNode) Parent.Parent; }
        }
    }
}