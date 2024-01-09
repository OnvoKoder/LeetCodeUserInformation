namespace LeetcodeUserInfo.Models.Leetcode
{
    public class MatchedUser
    {
        public string Username { get; private set; }
        public ProblemsSolvedBeatsStats[] ProblemsSolvedBeatsStats { get; private set; }
        public SubmitStats SubmitStats { get; private set; }
        
        public MatchedUser(string username, ProblemsSolvedBeatsStats[] problemsSolvedBeatsStats, SubmitStats submitStats)
        {
            Username = username;
            ProblemsSolvedBeatsStats = problemsSolvedBeatsStats;
            SubmitStats = submitStats;
        }
    }
}
