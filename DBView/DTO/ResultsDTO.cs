using System.Collections.Generic;
using DBView.Controls.Tree.Node;

namespace DBView.DTO
{
    public class ResultsDTO
    {
        private readonly IDBNode dbNode;
        private readonly List<string> childNodeNames;

        public ResultsDTO(IDBNode dbNode, List<string> childNodeNames)
        {
            this.dbNode = dbNode;
            this.childNodeNames = childNodeNames;
        }

        public List<string> ChildNodeNames
        {
            get { return childNodeNames; }
        }

        public IDBNode DbNode
        {
            get { return dbNode; }
        }
    }
}