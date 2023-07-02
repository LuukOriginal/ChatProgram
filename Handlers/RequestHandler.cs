using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProgram.Handlers
{
    public class RequestHandler
    {
        public string baseUrl;
        public RequestHandler(string BaseUrl) 
        {
            this.baseUrl = BaseUrl;
        }

        public string Get(string uri) //Handles GET requests
        {
            string responseBody = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + uri); //Send a simple HttpRequest
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseBody = reader.ReadToEnd(); //Reads the reponse and returns the result
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return responseBody;
        }

        public string Post(string uri, string data, string contentType, string method = "POST") //Handles POST requests
        {
            string responseBody = "";

            try
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + uri); //Send a simple HttpRequest
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.ContentLength = dataBytes.Length;
                request.ContentType = contentType;
                request.Method = method;

                using (Stream requestBody = request.GetRequestStream())
                {
                    requestBody.Write(dataBytes, 0, dataBytes.Length); //Add a body to the request
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseBody = reader.ReadToEnd(); //Return the response of the request
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"); //Show an error if something went wrong
                return "";
            }

            return responseBody;
        }
    }
}
