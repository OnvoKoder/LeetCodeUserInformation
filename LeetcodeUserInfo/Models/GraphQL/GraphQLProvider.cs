using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using LeetcodeUserInfo.Models.Leetcode;

namespace LeetcodeUserInfo.Models.GraphQL
{
    public class GraphQLProvider
    {
        private string GetQueryQntyQuestions()
        {
            return @"{ allQuestionsCount { 
			            difficulty 
			            count 
			            }
		            }";
        }

        private string GetQueryUserInfo()
        {
            return @"query ($username: String!) { matchedUser(username: $username) { 
						username
                        problemsSolvedBeatsStats { 
                        difficulty 
                        percentage 
                        }
					submitStats { 
				acSubmissionNum { 
					difficulty 
					count 
						} 
					} 
				}
			}";
        }

		public UserProfileData GetUserInfo(string username)
		{
            string query = "";
            GraphQLHttpClientOptions options = new GraphQLHttpClientOptions { EndPoint = new Uri("https://leetcode.com/graphql") };
            HttpClient httpClient = new HttpClient();
            GraphQLHttpClient client = new GraphQLHttpClient(options, new NewtonsoftJsonSerializer(), httpClient);
            query = GetQueryUserInfo();
            GraphQLRequest request = new GraphQLRequest(query);
            request.Variables = new { username = username};
            Task<GraphQLResponse<UserProfileData>> response = client.SendQueryAsync<UserProfileData>(request);
            UserProfileData user = response.Result.Data;
            return user;
		}
        public Submission[] GetQntyQuestions()
        {
            string query = "";
            GraphQLHttpClientOptions options = new GraphQLHttpClientOptions { EndPoint = new Uri("https://leetcode.com/graphql") };
            HttpClient httpClient = new HttpClient();
            GraphQLHttpClient client = new GraphQLHttpClient(options, new NewtonsoftJsonSerializer(), httpClient);
            query = GetQueryQntyQuestions();
            GraphQLRequest request = new GraphQLRequest(query);
            Task<GraphQLResponse<AllQuestions>> response = client.SendQueryAsync<AllQuestions>(request);
            AllQuestions questions = response.Result.Data;
            return questions.AllQuestionsCount;
        }
    }
}
