using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingCodeProject
{
    public class ConditionalOperatorSample
    {
        public void ConditionalOperatorSample1()
        {
            int saleAmount = 1000;
            int discount = saleAmount > 999 ? 100 : 50;

            Console.WriteLine($"Discount : {discount}");
        }
    }
}
