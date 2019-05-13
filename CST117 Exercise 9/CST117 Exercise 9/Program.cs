//Corrected by Seth Thompson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                /*code fix: only 0, 1, 2, and 3 can be generated with r.Next(4) which, with no duplicates will fill up Set object A before the loop has run 10 times.
                *Therefore the r.Next() should be for a number greater than or equal to 10.
                */
                //A.addElement(r.Next(4));
                A.addElement(r.Next(15));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            
            //code fix: Console remains open until a key is pressed to exit the screen.
            Console.ReadKey();
        }
    }
}
