using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition_task_ex1p4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int counter = 1;
            int counter2 = 0;
            string input = Console.ReadLine();
            int inputparse = int.Parse(input);

            while (counter > 0)
            {
                Console.Write("X");
                counter = counter - 1;
                if (counter == 0)
                {
                    counter2 = counter2 + 1;
                    counter = 1 + counter2;
                    Console.WriteLine();
                    if (counter == inputparse + 1)
                    {
                        counter = 0;
                    }
                }
            }

            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}