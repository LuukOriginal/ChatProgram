using Newtonsoft.Json;
using System.Web;

namespace ChatProgram.Handlers
{
    public class EndpointHandler
    {
        private RequestHandler requests;
        private string jsonContent = "application/json";

        public EndpointHandler(string BaseUrl) 
        {
            requests = new RequestHandler(BaseUrl);
        }

        //Creates a simple function to send a request to a specific endpoint
        public string CreateUser(string username) 
        {
            string jsonString = JsonConvert.SerializeObject(new { username = username });

            return requests.Post("/user", jsonString, jsonContent);
        }

        public string GetUser(string username)
        {
            return requests.Get("/user?username=" + HttpUtility.UrlEncode(username));
        }
    }
}
