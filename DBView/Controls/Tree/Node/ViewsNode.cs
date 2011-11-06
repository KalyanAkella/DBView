using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class ViewsNode : AbstractDBNode
    {
        public ViewsNode() : base("Views", NodeType.VIEWS)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }

        public override bool FindNext(FindDetails findDetails)
        {
            if (!findDetails.FindViews) return false;
            foreach (var node in Nodes)
            {
                var dbNode = (IDBNode) node;
                if (dbNode.DoesNodeMatch(findDetails)) return true;
            }
            return false;
        }

        public override bool FindPrevious(FindDetails findDetails)
        {
            if (!findDetails.FindViews) return false;
            foreach (var node in NodesInReverse)
            {
                var dbNode = (IDBNode) node;
                if (dbNode.DoesNodeMatch(findDetails)) return true;
            }
            return false;
        }
    }
}