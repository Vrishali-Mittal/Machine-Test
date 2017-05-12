using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
    class Task4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a Number:");
            string num = Console.ReadLine();
            string numbers = num.Replace(@"\\", @";"); //replace '/n' with ','
            string[] values = numbers.Split(';'); //putting values in array
            for (int i = 0; i < values.Length; i++)
            {


                if (values[i] == "")
                {
                    continue;
                }



                sum = sum + int.Parse(values[i]);

            }
            
            Console.WriteLine("Sum of digits of number is:" + sum);
            Console.ReadLine();
        }
    }
}
