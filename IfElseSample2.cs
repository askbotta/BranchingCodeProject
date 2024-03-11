using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingCodeProject
{
    public class IfElseSample2
    {
        public void IfElsesample()
        {
            int[] scores = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 0 };
            foreach (int score in scores)
            {
                if ( score >= 70)
                {
                    Console.WriteLine($"Score : {score}- A perfect Pass");
                }
                else if ( score >= 40 && score <= 70 )
                {
                    Console.WriteLine($"Score : {score}- Average");
                }
                else if (score  >= 10 && score <= 30 )
                {
                    Console.WriteLine($"Score : {score}- Poor");
                }
                else
                {
                    Console.WriteLine($"Score : {score} - BIG Zero");
                }
            }
        }
        
    }
}
