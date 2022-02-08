using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fullPath = Console.ReadLine();
            // C:\Users\Student\source\repos\individual\jack-updyke-student-code\module-1\16b_File_IO_Reading\exercise\WordSearch.Tests\dr_jekyll_mr_hyde.txt
            //2. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string searchWord = Console.ReadLine();

            //2a. Ask the user if the search should be case sensitive.

            Console.WriteLine("Should the search word be case sensitive (Y\\N)");
            string caseSensitive = Console.ReadLine();
            
            //3. Open the file

            try
            {


                using (StreamReader dataInput = new StreamReader(fullPath))
                {
                    if (caseSensitive == "Y" || caseSensitive == "y")
                    {
                        int lineNumber = 1;
                        while (!dataInput.EndOfStream)
                        {
                            
                            string line = dataInput.ReadLine();
                            //5. If the line contains the search string, print it out along with its line number


                            if (line.Contains(searchWord))
                            {
                                Console.WriteLine($"{ lineNumber}) {line}");
                            }
                            lineNumber++;
                        }
                    }

                    else if (caseSensitive == "N" || caseSensitive == "n")
                    {
                        int lineNumber = 1;
                        while(!dataInput.EndOfStream)
                        {
                            
                            string line = dataInput.ReadLine();
                            string upperSearchWord = searchWord.ToUpper();
                            string upperLine = line.ToUpper();
                            if (upperLine.Contains(upperSearchWord))
                            {
                                Console.WriteLine($"{ lineNumber}) {line}");
                            }
                            lineNumber++;
                        }



                    }
                                
                            
                 }
                        
             }
                    //4. Loop through each line in the file
                    
                
            

            catch(FileNotFoundException)
            {
                Console.WriteLine("File was not found.");
            }
            catch(IOException) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file.");
                
            }

            
            
        }
    }
}
