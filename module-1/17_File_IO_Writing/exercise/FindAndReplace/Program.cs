using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            Console.WriteLine("What is the search word?");
            string word = Console.ReadLine();

            Console.WriteLine("What is the replacement word?");
            string newWord = Console.ReadLine();

            Console.WriteLine("What is the source file?");
            string fullPathSourceFile = Console.ReadLine();

            Console.WriteLine("What is the destination file?");
            string fullPathDestinationFile = Console.ReadLine();

            try
            {
                using(StreamReader sr = new StreamReader(fullPathSourceFile))
                {
                    using(StreamWriter sw = new StreamWriter(fullPathDestinationFile))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            if(line.Contains(word))
                            {
                                line = line.Replace(word, newWord);
                            }

                            sw.WriteLine(line);

                        }
                    }
                    
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error finding file");
            }


        }
    }
}
