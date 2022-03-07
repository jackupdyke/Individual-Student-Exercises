using PetInfoClient.APIServices;
using PetInfoClient.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace WorldClient
{
    public class ConsoleService
    {

        private readonly PetAPIService petAPIService = new PetAPIService();
        private readonly OwnerAPIService ownerAPIService = new OwnerAPIService();

        public void Run()
        {
            PrintHeader();
            DisplayMenu();

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
                    case "q":
                    case "Q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }

                DisplayMenu();
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

        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1 - Add a pet");
            Console.WriteLine("2 - Delete a pet");
            Console.WriteLine("3 - Update a pet");
            Console.WriteLine("4 - List pets");
            Console.WriteLine("5 - List owners");
            Console.WriteLine("Q - Quit the program");
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

                //todo add owner name

                petAPIService.AddPet(temp);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to list pets: " + ex.Message);
            }
        }

        private void ListOwners()
        {
            List<Owner> owners = null;
            try
            {
                owners = ownerAPIService.GetOwners();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to list owners: " + ex.Message);
                return;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The owners are:");
            foreach (Owner owner in owners)
            {
                Console.WriteLine(owner);
            }
            Console.WriteLine();
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
    }
}





