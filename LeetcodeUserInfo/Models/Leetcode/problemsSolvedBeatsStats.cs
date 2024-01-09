namespace LeetcodeUserInfo.Models.Leetcode
{
    public class ProblemsSolvedBeatsStats
    {
        public string Difficulty { get; private set; }
        public string Percentage { get; private set; }
        public ProblemsSolvedBeatsStats(string difficulty, string percentage)
        {
            Difficulty = difficulty;
            Percentage = percentage != null ? percentage : "0.00";
        }
    }
}
