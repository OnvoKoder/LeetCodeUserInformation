namespace LeetcodeUserInfo.Models.Leetcode
{
    public class SubmitStats
    {
        public Submission[] AcSubmissionNum { get; private set; }
        public SubmitStats(Submission[] acSubmissionNum) => AcSubmissionNum = acSubmissionNum;
    }
}
