namespace Lb2
{
    public class MatchResult
    {
        public int MatchIndex { get; }
        public string OpName { get; }
        public int MatchRating { get; }
        public Status PStatus { get; }

        public MatchResult(int matchIndex, string opName, int matchRating,Status pStatus)
        {
            MatchIndex = matchIndex;
            OpName = opName;
            MatchRating = matchRating;
            PStatus = pStatus;
        }
    }
}