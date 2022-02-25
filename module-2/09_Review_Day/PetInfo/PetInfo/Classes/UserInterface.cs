using PetInfo.Classes.DAO;
using System;
using System.Collections.Generic;
using System.IO;

namespace PetInfo
{
    public class UserInterface
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=PetInfo;Integrated Security=True";

        private PetDAO petDAO;

        public UserInterface()
        {
            try
            {
                petDAO = new PetDAO(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error starting UserInterface: " + ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public void UserInput()
        {

            bool done = false;

            while (!done)
            {
                DisplayMenu();

                string input = Console.ReadLine();

                switch (input)
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
                    case "q":
                    case "Q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1 - Add a pet");
            Console.WriteLine("2 - Delete a pet");
            Console.WriteLine("3 - Update a pet");
            Console.WriteLine("4 - List pets");
            Console.WriteLine("Q - Quit the program");
        }

        private void AddAPet()
        {
            Console.Write("Enter pet name: ");
            string name = Console.ReadLine();

            Console.Write("Enter pet type (cat, dog, etc.): ");
            string type = Console.ReadLine();

            Console.Write("Enter pet breed (German Shapard, DSH, etc.): ");
            string breed = Console.ReadLine();

            bool result = false;

            try
            {
                result = petDAO.AddPet(name, type, breed);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error adding pet: " + ex.Message);
                return;
            }

            if (result)
            {
                Console.WriteLine("Pet added.");
            }
            else
            {
                Console.WriteLine("Failed to add pet.");
            }

        }

        private void ListPets()
        {
            List<Pet> result = new List<Pet>(); ;

            try
            {
                result = petDAO.GetPets();
            }
            catch  (Exception ex)
            {
                Console.WriteLine("Error reading pets: " + ex.Message);
            }

            Console.WriteLine();
            foreach (Pet pet in result)
            {
                Console.WriteLine(pet.ToString());
            }
        }

        private void DeleteAPet()
        {
            ListPets();
            Console.Write("Please enter a pet Id to delete(5, 23, etc.): ");
            int id = int.Parse(Console.ReadLine());

            bool result = false;

            try
            {
                result = petDAO.DeletePet(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting pet: " + ex.Message);
                return;
            }

            if (result)
            {
                Console.WriteLine("Pet deleted.");
            }
            else
            {
                Console.WriteLine("Failed to delete pet.");
            }
        }

        private void UpdateAPet()
        {
            ListPets();

            Console.Write("Please enter a pet Id to update(5, 23, etc.): ");
            int id = int.Parse(Console.ReadLine());

            Pet pet = null;

            try
            {
                 pet = petDAO.GetPet(id);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading pet.");
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
                if (petDAO.UpdatePet(pet))
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
                Console.WriteLine("Error while updating pet.");
            }


        }
    }
}
