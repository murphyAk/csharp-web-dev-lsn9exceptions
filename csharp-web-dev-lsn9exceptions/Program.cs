using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName.EndsWith("cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter overall score: ");
            double totalScore = double.Parse(Console.ReadLine());
            Console.Write("Enter student score: ");
            double studentScore = double.Parse(Console.ReadLine());

            try
            {
                double grade = Divide(studentScore, totalScore);

                if (totalScore == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine($"Score is {Divide(studentScore, totalScore) * 100}");

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("you cannot divide by zero!");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> submissions in students)
            {
                try
                {
                    if (submissions.Value == null || submissions.Value == "")
                    {
                        throw new NullReferenceException();
                    }
                    Console.WriteLine(CheckFileExtension(submissions.Value));
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Invalid file format");
                }
            }



        }
    }
}
