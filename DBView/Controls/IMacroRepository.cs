namespace DBView.Controls
{
    public interface IMacroRepository
    {
        bool CanExpand(string word);
        string GetExpansionFor(string word);
    }
}