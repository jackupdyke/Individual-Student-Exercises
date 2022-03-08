using PetInfoClient.APIServices;
using PetInfoClient.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace WorldClient
{
    public class ConsoleService
    {

        private PetAPIService petAPIService = new PetAPIService();
        private OwnerAPIService ownerAPIService = new OwnerAPIService();
        private LoginAPIService loginAPIService = new LoginAPIService();
        private ActivityAPIService activityAPIService = new ActivityAPIService();

        public void Run()
        {
            PrintHeader();
            PrintMenu();

            bool done = false;

            while (!done)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddAPet();
                        break;
                    case "2":
                        DeleteAPet();
                        break;

                    case "3":
                        UpdateAPet();
                        break;

                    case "4":
                        ListPets();
                        break;

                    case "5":
                        ListOwners();
                        break;

                    case "6":
                        ListActivities();
                        break;

                    case "8":
                        Register();
                        break;

                    case "9":
                        LogInOrOut();
                        break;

                    case "q":
                    case "Q":
                        done = true;
                        continue;

                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }

                PrintMenu();
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@":'########::'########:'########:'####:'##::: ##:'########::'#######:: ");
            Console.WriteLine(@": ##.... ##: ##.....::... ##..::. ##:: ###:: ##: ##.....::'##.... ##: ");
            Console.WriteLine(@": ##:::: ##: ##:::::::::: ##::::: ##:: ####: ##: ##::::::: ##:::: ##: ");
            Console.WriteLine(@": ########:: ######:::::: ##::::: ##:: ## ## ##: ######::: ##:::: ##: ");
            Console.WriteLine(@": ##.....::: ##...::::::: ##::::: ##:: ##. ####: ##...:::: ##:::: ##: ");
            Console.WriteLine(@": ##:::::::: ##:::::::::: ##::::: ##:: ##:. ###: ##::::::: ##:::: ##: ");
            Console.WriteLine(@": ##:::::::: ########:::: ##::::'####: ##::. ##: ##:::::::. #######:: ");
            Console.WriteLine(@"..:::::::::........:::::..:::::....::..::::..::..:::::::::.......::: ");
            // from: http://www.network-science.de/ascii/ with banner3-D
        }

        private void PrintMenu()
        {
            string logInOut = loginAPIService.LoggedIn ? "Log out" : "Log in";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Main-Menu Type in a command");
            Console.WriteLine(" 1 - Add a pet");
            Console.WriteLine(" 2 - Delete a pet");
            Console.WriteLine(" 3 - Update a pet");
            Console.WriteLine(" 4 - List pets");
            Console.WriteLine(" 5 - List owners");
            Console.WriteLine(" 6 - List activities");
            Console.WriteLine(" 8 - Register");
            Console.WriteLine(" 9 - " + logInOut);
            Console.WriteLine(" Q - Quit");
        }

        private void DeleteAPet()
        {
            try
            {
                Console.WriteLine("Please select the pet to delete.");
                ListPets();
                Console.Write("Please enter a pet number: ");
                int petNumber = int.Parse(Console.ReadLine());
                bool result = petAPIService.DeletePet(petNumber);
                if (result)
                {
                    Console.WriteLine("Deleted.");
                }
                else
                {
                    Console.WriteLine("ERROR: Unable to delete.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine();
                Console.WriteLine("Unable to list pets: " + ex.Message);
            }

        }

        private void ListPets()
        {
            try
            {
                List<Pet> pets = petAPIService.GetPets();

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("The pets are:");
                foreach (Pet pet in pets)
                {
                    Console.WriteLine(pet);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine();
                Console.WriteLine("Unable to list pets: " + ex.Message);
            }
        }

        private void ListActivities()
        {
            try
            {
                List<Activity> activities = activityAPIService.GetActivities();

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("The activities are:");
                foreach (Activity activity in activities)
                {
                    Console.WriteLine(activity);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine();
                Console.WriteLine("Unable to list activities: " + ex.Message);
            }
        }


        private void AddAPet()
        {
            try
            {
                Pet temp = new Pet();

                Console.Write("Enter name: ");
                temp.Name = Console.ReadLine();

                Console.Write("Enter type (dog, cat, parrot, etc.): ");
                temp.Type = Console.ReadLine();

                Console.Write("Enter breed (Chow, German Shepard, DSH, etc.): ");
                temp.Breed = Console.ReadLine();

                ListOwners();

                Console.Write("Enter Owner Id (1001): ");
                temp.Owner = int.Parse(Console.ReadLine());

                bool answer = petAPIService.AddPet(temp);

                if (answer == true)
                {
                    Console.WriteLine("added a pet.");
                }
                else
                {
                    Console.WriteLine("Unable to add a pet");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to list pets: " + ex.Message);
            }
        }

        private void UpdateAPet()
        {
            ListPets();

            Console.Write("Please enter a pet Id to update(5, 23, etc.): ");
            int id = int.Parse(Console.ReadLine());   //todo catch errors here

            Pet pet = null;

            try
            {
                pet = petAPIService.GetPet(id);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading pet. " + ex.Message);
            }

            if (pet == null)
            {
                Console.WriteLine("Pet not found.");
                return;
            }

            Console.Write("Enter pet name(press Enter to leave unchanged): ");
            string name = Console.ReadLine();
            if (name != "")
            {
                pet.Name = name;
            }

            Console.Write("Enter pet type (cat, dog, etc.)(press Enter to leave unchanged): ");
            string type = Console.ReadLine();
            if (type != "")
            {
                pet.Type = type;
            }

            Console.Write("Enter pet breed (German Shapard, DSH, etc.)(press Enter to leave unchanged): ");
            string breed = Console.ReadLine();
            if (breed != "")
            {
                pet.Breed = breed;
            }

            try
            {
                if (petAPIService.UpdatePet(pet) != null)
                {
                    Console.WriteLine("Updated pet.");
                }
                else
                {
                    Console.WriteLine("Not able to update pet.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error while updating pet. " + ex.Message);
            }
        }

        private void ListOwners()
        {
            Console.WriteLine("John - 1000");
            Console.WriteLine("Lisa - 1001");
            Console.WriteLine();
            //List<Owner> owners = ownerAPIService.GetOwners();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("The owners are:");
            //foreach (Owner owner in owners)
            //{
            //    Console.WriteLine(owner);
            //}
            //Console.WriteLine();
        }

        private void Register()
        {
            Console.Write("Please enter username: ");
            string username = Console.ReadLine();
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();
            try
            {
                bool login = loginAPIService.Register(username, password);
                if (login)
                {
                    Console.WriteLine("You are now registered. Please log in.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LogInOrOut()
        {
            if (loginAPIService.LoggedIn)
            {
                loginAPIService.Logout();
                Console.WriteLine("You are now logged out");
            }
            else
            {
                Console.Write("Please enter username: ");
                string username = Console.ReadLine();
                Console.Write("Please enter password: ");
                string password = Console.ReadLine();
                try
                {
                    var login = loginAPIService.Login(username, password);
                    if (login)
                    {
                        Console.WriteLine("You are now logged in");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}




