using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class Pet
    {
        public string petName = "Bella";

        public string PetType { get; set; }
        public int PetAge { get; set; }

        public string Color { get; } = "brown";


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
