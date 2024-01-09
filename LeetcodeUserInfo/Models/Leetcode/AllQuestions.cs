namespace LeetcodeUserInfo.Models.Leetcode
{
    public class AllQuestions
    {
        public Submission[] AllQuestionsCount { get; private set; }
        public AllQuestions(Submission[] allQuestionsCount)
        {
            AllQuestionsCount = allQuestionsCount;
        }
    }
}
