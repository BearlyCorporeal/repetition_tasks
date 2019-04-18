using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition_task_ex2p3
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            int space = 0;
            int spacecounter = 0;
            int xamount = 0;
            int xamountcount = 0;

            while (counter < 6)
            {
                counter = counter + 1;
                space = 6 - counter;
                if (counter == 1)
                {
                    xamount = counter;
                    space = 6 - 1;
                }
                else
                {
                    xamount = ((counter + 1) * 2) - 3;
                    space = 6 - counter;
                }
                while (spacecounter < space)
                {
                    spacecounter = spacecounter + 1;
                    Console.Write(" ");
                }
                spacecounter = 0;
                while (xamountcount < xamount)
                {
                    xamountcount = xamountcount + 1;
                    Console.Write("x");
                }
                xamountcount = 0;
                Console.WriteLine();


            }
            Console.ReadKey();
        }
    }
}
