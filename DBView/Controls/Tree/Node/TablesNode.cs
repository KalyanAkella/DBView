using DBView.DTO;

namespace DBView.Controls.Tree.Node
{
    public class TablesNode : AbstractDBNode
    {
        public TablesNode() : base("Tables", NodeType.TABLES)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }

        public override bool FindNext(FindDetails findDetails)
        {
            if (!findDetails.FindTables) return false;
            foreach (var node in Nodes)
            {
                var dbNode = (IDBNode) node;
                if (dbNode.DoesNodeMatch(findDetails)) return true;
            }
            return false;
        }

        public override bool FindPrevious(FindDetails findDetails)
        {
            if (!findDetails.FindTables) return false;
            foreach (var node in NodesInReverse)
            {
                var dbNode = (IDBNode) node;
                if (dbNode.DoesNodeMatch(findDetails)) return true;
            }
            return false;
        }
    }
}