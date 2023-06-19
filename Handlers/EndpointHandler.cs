using Newtonsoft.Json;


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

        public string CreateUser(string username)
        {
            string jsonString = JsonConvert.SerializeObject(new { username = username });

            return requests.Post("/User", jsonString, jsonContent);
        }
    }
}
