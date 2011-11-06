using System;

namespace DBView.Controls.Tree.Node
{
    public class NullMacroRepository : IMacroRepository
    {
        public bool CanExpand(string word)
        {
            return false;
        }

        public string GetExpansionFor(string word)
        {
            throw new NotImplementedException();
        }
    }
}