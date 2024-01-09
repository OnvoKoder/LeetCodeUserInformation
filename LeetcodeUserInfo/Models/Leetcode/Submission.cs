namespace LeetcodeUserInfo.Models.Leetcode
{
    public class Submission
    {
        public int Count { get; private set; } 
        public string Difficulty { get; private set; }
        public Submission(int count, string difficulty)
        {
            Count = count;
            Difficulty = difficulty;
        }
    }
}
