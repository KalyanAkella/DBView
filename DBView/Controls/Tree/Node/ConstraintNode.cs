namespace DBView.Controls.Tree.Node
{
    public class ConstraintNode : AbstractDBNode
    {
        public ConstraintNode(string text) : base(text, NodeType.CONSTRAINT)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }
    }
}