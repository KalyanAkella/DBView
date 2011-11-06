using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public abstract class AbstractDBNode : TreeNode, IDBNode
    {
        protected readonly string NODE_EXPANDING;
        protected readonly string NODE_NORMAL;

        protected AbstractDBNode(string text) : base(text)
        {
            NODE_EXPANDING = Text + " (Expanding...)";
            NODE_NORMAL = Text;
        }

        protected AbstractDBNode(string text, NodeType nodeType) : this(text)
        {
            Tag = nodeType;
        }

        public abstract bool HasDBNodesAsChildren { get; }

        public virtual bool FindNext(FindDetails findDetails)
        {
            return false;
        }

        public virtual bool FindPrevious(FindDetails findDetails)
        {
            return false;
        }

        public virtual void BeginExpand()
        {
            Text = NODE_EXPANDING;
        }

        public List<string> ProcessExpand()
        {
            try
            {
                return ProcessExpandSafely();
            }
            catch (Exception)
            {
                if (TreeView.InvokeRequired && TreeView.IsHandleCreated)
                    TreeView.Invoke(new Action(delegate
                                                   {
                                                       Text = NODE_NORMAL;
                                                       Nodes.Clear();
                                                   }));
                throw;
            }
        }

        public virtual List<string> ProcessExpandSafely()
        {
            return null;
        }

        public virtual void FinishExpand(List<string> childNodeNames)
        {
            Text = NODE_NORMAL;
            Nodes.Clear();
        }

        public virtual bool UpdateContextMenu(ContextMenuStrip contextMenuStrip)
        {
            contextMenuStrip.Items.Clear();
            return false;
        }

        public virtual bool DoesNodeMatch(FindDetails findDetails)
        {
            var nodeFound = false;
            var nodeText = Text;
            var findStr = findDetails.FindStr;

            if (CannotMatch(findDetails)) return false;

            if (!findDetails.MatchCase)
            {
                nodeText = nodeText.ToUpper();
                findStr = findStr.ToUpper();
            }

            if (findDetails.MatchWholeString)
            {
                if (nodeText.Equals(findStr))
                {
                    TreeView.SelectedNode = this;
                    EnsureVisible();
                    nodeFound = true;
                }
            }
            else
            {
                if (nodeText.Contains(findStr))
                {
                    TreeView.SelectedNode = this;
                    EnsureVisible();
                    nodeFound = true;
                }
            }
            return nodeFound;
        }

        private bool CannotMatch(FindDetails findDetails)
        {
            var tag = (NodeType) Tag;
            var canMatch = true;
            if (tag == NodeType.TABLE && !findDetails.FindTables) canMatch = false;
            if (tag == NodeType.PKG && !findDetails.FindPkgs) canMatch = false;
            if (tag == NodeType.VIEW && !findDetails.FindViews) canMatch = false;
            return !canMatch;
        }

        protected ArrayList NodesInReverse
        {
            get
            {
                var nodesListInReverse = new ArrayList(Nodes.Count);
                nodesListInReverse.AddRange(Nodes);
                nodesListInReverse.Reverse();
                return nodesListInReverse;
            }
        }
    }
}