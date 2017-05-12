using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
    class Task7
    {
        static void Main(string[] args)
	{
			int sum = 0 ;
            Console.WriteLine("Enter a Number : ");

            string num = Console.ReadLine();

			string[] values = num.Split(',');
			for(int i=0; i<values.Length;i++){
				if(int.Parse(values[i]) < 1000){
					sum = sum + int.Parse(values[i]);
				}
				
			}
		
		  Console.WriteLine("Sum of Digits of the Number : "+sum);
         
	}
}
    }

