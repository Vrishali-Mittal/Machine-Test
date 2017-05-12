using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
    class Task5
    {
        static void main(string[] args)
        {
            int sum = 0, flag = 0;
            Console.WriteLine("Enter a number:");
            string num = Console.ReadLine();
            string numbers = num.Replace(@"\\", @",");
            string[] values = numbers.Split(',');
            for(int i=0;i<values.Length;i++)
            {
                if(values[i]=="")
                {
                    continue;
                }
                else if (int.Parse(values[i]) < 0)
                {
                    flag = 1;
                }
                else
                {
                    sum = sum + int.Parse(values[i]);
                }
            }
            if (flag==1)
            {
                Console.WriteLine("Negative numbers not allowed");

            }
            else
            {
                Console.WriteLine("Sum of digits is:" + sum);
            }

        }
            
    }
}
