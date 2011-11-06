namespace DBView.DTO
{
    public class FindDetails
    {
        public FindDetails()
        {
            FindTables = true;
            FindPkgs = true;
            FindViews = true;
        }

        public string FindStr { get; set; }
        public bool FindTables { get; set; }
        public bool FindPkgs { get; set; }
        public bool FindViews { get; set; }
        public bool MatchWholeString { get; set; }
        public bool MatchCase { get; set; }
    }
}