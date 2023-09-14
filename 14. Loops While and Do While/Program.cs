using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Loops_While_and_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is now the normal while loop");
            int index = 0;

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("This is now the do while loop");
            int index2 = 0;
        

            do
            { 
                Console.WriteLine(index2);
                index2++;
            } 
            
            
            while(index2 <= 5);

            //freeze
            Console.Read();
            
            
        }
    }
}
