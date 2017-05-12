using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
    class Task8
    {
        static void Main(string[] args)
        {
            int mul = 1;
            Console.WriteLine("Enter a Number:");
            string num = Console.ReadLine();
            string[] values = num.Split(',');
            for (int i = 0; i < values.Length; i++)
            {


                mul = mul * int.Parse(values[i]);
            
              
            }
            Console.WriteLine("multiply of digits of number is:" + mul);
            Console.ReadLine();
        }
        }
    }
}
