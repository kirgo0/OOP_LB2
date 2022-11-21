namespace Lb2
{
    public class MatchResult
    {
        public MatchType MType { get; }
        public int MatchIndex { get; }
        public string OpName { get; }
        public int MatchRating { get; }
        public Status PStatus { get; }

        public MatchResult( MatchType mType, int matchIndex, string opName, int matchRating,Status pStatus)
        {            
            MatchIndex = matchIndex;
            OpName = opName;
            MatchRating = matchRating;
            PStatus = pStatus;
            MType = mType;
        }
    }
}