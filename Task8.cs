using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
{
public class MultiplyNumbers
{
int result = 0;
MulNumbers()
{
result = 1;
}
public void multiplication(string[] arrValues)
{
try
{
for (int i = 0; i < arrValues.Length; i++)
{
{
result = result * int.Parse(arrValues[i]);
}
}
 
}
catch (FormatException e)
{
Console.WriteLine("Exception caught: {0}", e);
}
finally
{
Console.WriteLine("Multiplication of digits of number is: {0}", result);
}
}
public static void Main()
{
Console.WriteLine("Enter a Number:");
string num = Console.ReadLine();
string[] values = num.Split(','); //putting values in array
MulNumbers mul = new MulNumbers();
mul.multiplication(values);
}
}
}

