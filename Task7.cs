using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class AddNumbers
    {
        int result = 0;
        AddNumbers()
        {
            result = 0;
        }
        public void addition(string[] arrValues)
        {
            try
            {
                for (int i = 0; i < arrValues.Length; i++)
                {
                    if (int.Parse(arrValues[i]) < 1000)
                    {
                        result = result + int.Parse(arrValues[i]);
                    }            
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Sum of digits is:" + result);
                Console.ReadLine();
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a Number:");
            string num = Console.ReadLine();
            string[] values = num.Split(';'); //putting values in array
            AddNumbers add = new AddNumbers();
            add.addition(values);
        }
    }
}


