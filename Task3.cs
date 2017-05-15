using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_net_Vrishali
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
Console.WriteLine("Sum of digits of number is: {0}", result);
Console.ReadLine();
}
}
public static void Main()
{
Console.WriteLine("Enter a Number:");
string num = Console.ReadLine();
string numbers = num.Replace("\\n", ","); //replace '/n' with ','
string[] values = numbers.Split(','); //putting values in array
AddNumbers add = new AddNumbers();
add.addition(values);
}
}
}
