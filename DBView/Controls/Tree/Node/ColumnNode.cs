namespace DBView.Controls.Tree.Node
{
    public class ColumnNode : AbstractDBNode
    {
        public ColumnNode(string text) : base(text, NodeType.COLUMN) {}

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }
    }
}