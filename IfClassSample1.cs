using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingCodeProject
{
    public class IfClassSample1
    {
        public void Sample1()
        {
            // Initialize an array of scores
            int[] scores = {0,90, 55, 60, 74, 80, 100,0, 45, 67, 100 };

            // First foreach loop to classify each score as Pass or Fail
            Console.WriteLine("Score Classification (Pass/Fail):");
            foreach (int score in scores)
            {
                if (score >= 60)
                {
                    Console.WriteLine($"Score: {score} - Pass");
                }
                else
                {
                    Console.WriteLine($"Score: {score} - Fail");
                }
            }

            Console.WriteLine("\nPerfect Scores:");
            // Second foreach loop to identify and print perfect scores
            foreach (int score in scores)
            {
                if (score == 100)
                {
                    Console.WriteLine($"Score: {score} - Perfect Score");
                }
            }

            Console.WriteLine($"\nPerfect Zero");
            foreach (int score in scores)
            {
                if (score <= 0 )
                {
                    Console.WriteLine($"A perfect zero score");
                }
            }
        }
    }

}

