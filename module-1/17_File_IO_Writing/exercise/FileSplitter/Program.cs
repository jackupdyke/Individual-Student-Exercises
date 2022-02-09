using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where is the input file (please include the path to the file)?");
            string inputFile = Console.ReadLine();

            Console.Write("How many lines of text (max) should there be in the split files?");
            int maxLinePerFile = int.Parse(Console.ReadLine());

            
            Console.WriteLine("The input file has 50 lines of text.");
            Console.WriteLine();

            int outputFileCount = 50 / maxLinePerFile;
            Console.WriteLine($"For a 50 line input file {"input.txt"}, this produces {outputFileCount} output files.");
            Console.WriteLine();

            Console.WriteLine("**GENERATING OUTPUT**");
            Console.WriteLine();

           // string inputPath = @"C:\Users\Student\source\repos\individual\jack-updyke-student-code\module-1\17_File_IO_Writing\exercise\FileSplitter\input.txt";
            try
            {
                using(StreamReader sr = new StreamReader(inputFile))
                {
                    


                        for (int i = 1; i <= outputFileCount + 1; i++)
                        {

                            string smallFileName = "input-" + i.ToString() + ".txt";
                            Console.WriteLine($"Generating {smallFileName}");

                            using (StreamWriter sw = new StreamWriter(smallFileName))
                            {
                                string line1 = sr.ReadLine();
                                string line2 = sr.ReadLine();
                                string line3 = sr.ReadLine();
                                
                                sw.WriteLine(line1);
                                sw.WriteLine(line2);
                                sw.WriteLine(line3);

                                
                            }
                        }
                    
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error finding the file.");
            }
        }
    }
}
