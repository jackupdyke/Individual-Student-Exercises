using PetInfoClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Web;



namespace PetInfoClient.APIServices
{
    public class PetAPIService : LoginAPIService
    {
        private readonly string API_URL = "https://localhost:44349/pet/";


        public List<Pet> GetPets()
        {
            //List<Pet> pets = new List<Pet>();

            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Pet>> response = client.Get<List<Pet>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }
        }

        public Pet GetPet(int id)
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<Pet> response = client.Get<Pet>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if ((int)response.StatusCode == 404)
            {
                return null;
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }
        }



        public bool AddPet(Pet pet)
        {
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(pet);
            IRestResponse<bool> response = client.Post<bool>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

        }

        public bool DeletePet(int petId)
        {
            return false;
        }

        public Pet UpdatePet(Pet pet)
        {
            return new Pet();
        }

        private void CheckResult(IRestResponse<Pet> response)
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
