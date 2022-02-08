using System;
using System.IO;
using System.Collections.Generic;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {

            List<string> info = new List<string>();
            info.Add(DateTime.Now.ToString());
            info.Add("weoburog");
            info.Add("wekjgreg");
            info.Add("weogunetug");

            string path = @"c:\NicePlace\OutputFile.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach(string item in info)
                    {
                        sw.WriteLine(item);
                    }
                }

            }
            catch(IOException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }

            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
