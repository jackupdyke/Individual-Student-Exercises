using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

////namespace QuizMaker
////{
////    class AnswerKey
////    {
////        public static void Main(string[] args)
////        {
////            //1. Ask the user for the file path
////            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions.");
////            string directory = @"C:\Users\Student\source\repos\individual\jack-updyke-student-code\module-1\16b_File_IO_Reading\exercise";
////            string filename = "sample-quiz-file.txt";
////            string fullPath = Path.Combine(directory, filename);

////            List<string> quizQuestions = new List<string>();

////            using (StreamReader sr = new StreamReader(fullPath))
////            {
////                while(!sr.EndOfStream)
////                {
////                    string line = sr.ReadLine();

////                    string[] questions = line.Split('|');
////                    quizQuestions.AddRange(questions);
////                }
////            }
            
////            foreach(string questions in quizQuestions)
////            {
                
////                    if (questions.Contains('*'))
////                    {
////                        Console.WriteLine(questions.Substring(0, questions.Length - 1));
////                    }
////                    else
////                    {
////                        Console.WriteLine(questions);
////                    }
                
                
                
////            }
            
////         }
////    }
////}
