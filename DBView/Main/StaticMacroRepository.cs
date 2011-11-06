using System.Collections.Generic;
using DBView.Controls;

namespace DBView.Main
{
    public class StaticMacroRepository : IMacroRepository
    {
        private IDictionary<string, string> macros;

        public StaticMacroRepository()
        {
            macros = new Dictionary<string, string>()
                         {
                             {"sf", "select * from"},
                             {"it", "insert into"},
                             {"df", "delete from"},
                             {"u", "update"},
                         };
        }

        public bool CanExpand(string word)
        {
            return macros.ContainsKey(word.ToLower());
        }

        public string GetExpansionFor(string word)
        {
            return macros[word];
        }
    }
}