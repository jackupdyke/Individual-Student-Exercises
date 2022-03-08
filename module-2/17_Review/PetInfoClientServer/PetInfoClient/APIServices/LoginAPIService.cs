using PetInfoClient.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfoClient.APIServices
{
    public class LoginAPIService
    {
        protected static RestClient client = new RestClient();

        private readonly string API_URL = "https://localhost:44349/login/";
        private ReturnUser user = new ReturnUser();

        public bool LoggedIn { get { return !string.IsNullOrWhiteSpace(user.Token); } }

        public bool Login(string submittedName, string submittedPass)
        {
            LoginUser loginUser = new LoginUser { Username = submittedName, Password = submittedPass };
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(loginUser);
            IRestResponse<ReturnUser> response = client.Post<ReturnUser>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                if (response.Data != null && !string.IsNullOrWhiteSpace(response.Data.Message))
                {
                    throw new Exception("An error message was received: " + response.Data.Message);
                }
                else
                {
                    throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
                }
            }
            else
            {
                user = response.Data;
                client.Authenticator = new JwtAuthenticator(user.Token);
                return true;
            }
        }

        public void Logout()
        {
            user = new ReturnUser();
            client.Authenticator = null;
        }

        public bool Register(string submittedName, string submittedPass)
        {
            LoginUser loginUser = new LoginUser { Username = submittedName, Password = submittedPass };
            RestRequest request = new RestRequest(API_URL + "register");
            request.AddJsonBody(loginUser);
            IRestResponse<ReturnUser> response = client.Post<ReturnUser>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                string message = "";
                if (!string.IsNullOrEmpty(response.Content))
                {
                    message = response.Content;
                }
                throw new Exception("Error occurred - received non-success response: " +
                    response.StatusCode + " "  + message) ;
            }
            else
            { 
                return true;
            }
        }
    }
}
