﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class RectangleWall : Wall
    {

        

        public  RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            
            Length = length;
            Height = height;
        }
        public int Length { get; }
        public int Height { get; }
       
       

        public override int GetArea()
        {
            return Length * Height;
        }
        
        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) rectangle";
        }
        
    }
}
