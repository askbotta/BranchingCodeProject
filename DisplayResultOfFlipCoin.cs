using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingCodeProject
{
    public class DisplayResultOfFlipCoin
    {
        public void CointProject()
        {
          Random coin = new Random();
            int flip = coin.Next(0,2);

            Console.WriteLine((flip == 0)? "heads" : "tails");
            //OR
            Console.WriteLine(coin.Next(0, 2) == 0 ? "heads" : "tails");


        }
    }
}
