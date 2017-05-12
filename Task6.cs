using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
    class Task6
    {
        static void Main(string[] args)
	{
			int sum = 0, flag =0 ;
			string[] Err = new String[] {};
		
			List<int> errVal = new List<int>();//arry containing list of numbers


            Console.WriteLine("Enter a Number : ");

            string num = Console.ReadLine();

           	string numbers = num.Replace(@"\\" , @",");
			string[] values = numbers.Split(',');
			for(int i=0; i<values.Length;i++){
				if(values[i]==""){
					continue;
			}
			else if(int.Parse(values[i]) < 0){
				flag = 1;
				errVal.Add(int.Parse(values[i]));
			}
			else{
				sum = sum + int.Parse(values[i]);
			}
			
			
		}
		if(flag==1){
			string ErrVal = "";
			for(int k=0; k<errVal.Count;k++){
			ErrVal = ErrVal + errVal[k] + ",";
			}
			ErrVal = ErrVal.TrimEnd(',');
		  Console.WriteLine("Error: Negative numbers ("+ErrVal+") not allowed.");
		}
		else{
		  Console.WriteLine("Sum of Digits of the Number : "+sum);
		}
          

         
	}
}

    }

