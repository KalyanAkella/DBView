using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class PackagesNode : AbstractDBNode
    {
        public PackagesNode() : base("Packages", NodeType.PKGS)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }

        public override bool FindNext(FindDetails findDetails)
        {
            if (!findDetails.FindPkgs) return false;
            foreach (var node in Nodes)
            {
                var dbNode = (IDBNode) node;
                if (dbNode.DoesNodeMatch(findDetails)) return true;
            }
            return false;
        }

        public override bool FindPrevious(FindDetails findDetails)
        {
            if (!findDetails.FindPkgs) return false;
            foreach (var node in NodesInReverse)
            {
                var dbNode = (IDBNode) node;
                if (dbNode.DoesNodeMatch(findDetails)) return true;
            }
            return false;
        }
    }
}