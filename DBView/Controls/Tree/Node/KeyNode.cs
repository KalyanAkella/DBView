namespace DBView.Controls.Tree.Node
{
    public class KeyNode : AbstractDBNode
    {
        public KeyNode(string text) : base(text, NodeType.KEY_COLUMN)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }
    }
}