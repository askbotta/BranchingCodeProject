using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingCodeProject
{
    public class ExpressionEqualityOperator
    {
        public void EqualityOperator()
        {
            Console.WriteLine("a" == "a ");
            Console.WriteLine("b" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue = "a");

            // Console.WriteLine("a" = "a ");

            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


            Console.WriteLine("a " != "a");

            Console.WriteLine("a" != "a ");
            Console.WriteLine("b" != "A");
            Console.WriteLine(1 != 2);

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));

            //Logical Negation operator
            string pangram1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(!pangram1.Contains("fox"));
            Console.WriteLine(!pangram1.Contains("cow"));

            //Inequality operator versus logical negation
        }
    }
}
