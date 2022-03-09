using PetInfoClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Web;



namespace PetInfoClient.APIServices
{
    public class ActivityAPIService : LoginAPIService
    {
        private readonly string API_URL = "https://localhost:44349/activity/";


        public List<Activity> GetActivities()
        {

            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Activity>> response = client.Get<List<Activity>>(request);

            CheckResult(response);

            return response.Data;
        }


        private void CheckResult(IRestResponse<List<Activity>> response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if ((int)response.StatusCode == 401)
            {
                throw new Exception("Error occurred - user not authorized - 401.");
            }
            else if ((int)response.StatusCode == 403)
            {
                throw new Exception("Error occurred - user forbidden - 403");
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
        }
    }
}
