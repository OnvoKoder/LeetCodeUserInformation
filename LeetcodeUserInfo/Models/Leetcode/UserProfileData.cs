using LeetcodeUserInfo.Models.GraphQL;

namespace LeetcodeUserInfo.Models.Leetcode
{
    public class UserProfileData
    {
        public MatchedUser MatchedUser { get; private set; }
        public Submission[] AllQuestionsCount { get; private set; }
        private GraphQLProvider provider = new GraphQLProvider();
        public UserProfileData(MatchedUser matchedUser)
        {
            MatchedUser = matchedUser;
            AllQuestionsCount = provider.GetQntyQuestions();
        }
    }
}
