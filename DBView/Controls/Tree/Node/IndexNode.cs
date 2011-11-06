namespace DBView.Controls.Tree.Node
{
    public class IndexNode : AbstractDBNode
    {
        public IndexNode(string text) : base(text, NodeType.INDEX)
        {
        }

        public override bool HasDBNodesAsChildren
        {
            get { return false; }
        }
    }
}