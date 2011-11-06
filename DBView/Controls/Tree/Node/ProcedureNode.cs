namespace DBView.Controls.Tree.Node
{
    public class ProcedureNode : AbstractDBNode
    {
        public ProcedureNode(string text) : base(text, NodeType.PROC)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }
    }
}