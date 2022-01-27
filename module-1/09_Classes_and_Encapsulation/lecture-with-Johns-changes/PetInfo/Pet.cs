using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class Pet
    {
        public Pet()
        {
            Console.WriteLine("Reached constructor.");
        }


        public Pet(string petName)
        {
            this.petName = petName;
        }


        public string petName = "Default Dog";

        /**
        * This is the intellisense block
        * that shows up
        */
        public string PetType { get; set; }
        public int PetAge { get; set; }

        public string Color { get; private set; } = "brown";

        public void SetColor(string newColor)
        {
            Color = newColor;
            return;
        }


        private string eyeColor = "";
        public string EyeColor
        {
            get
            {
                return eyeColor;
            }
            set
            {
                if (value == "Black" || value == "Brown")
                {
                    eyeColor = value;
                }
            }
        }

        public string DisplayInfo()
        {
            return $"{petName} - {PetType} - {PetAge} - {Color} - {EyeColor}";
        }
    }
}
