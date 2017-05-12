using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
    class Task2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a Number:");
            string num = Console.ReadLine();
            string[] values = num.Split(','); //putting values in array
            for (int i = 0; i < values.Length; i++)
            {

                {
                    sum = sum + int.Parse(values[i]);
                }


            }
            //results sum of multiple digits
            Console.WriteLine("Sum of digits of number is:" + sum);
            Console.ReadLine();
        }
    }
}
