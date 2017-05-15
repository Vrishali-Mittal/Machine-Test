using System;
using System.Collections.Generic;
public class AddNumbers
{
int result = 0, flag = 0;
List<int> errVal = new List<int>();//arry containing list of numbers
string[] Err = new String[] { };
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
if (arrValues[i] == "")
{
continue;
}
else if (int.Parse(arrValues[i]) < 0)
{
flag = 1;
errVal.Add(int.Parse(arrValues[i]));
}
else
{
result = result + int.Parse(arrValues[i]);
}
}
if (flag == 1)
{
string ErrVal = "";
for (int k = 0; k < errVal.Count; k++)
{
ErrVal = ErrVal + errVal[k] + ",";
}
ErrVal = ErrVal.TrimEnd(',');
Console.WriteLine("Error: Negative numbers (" + ErrVal + ") not allowed.");
}
else
{
Console.WriteLine("Sum of digits of number is: {0}", result);
}
}
catch (FormatException e)
{
Console.WriteLine("Exception caught: {0}", e);
}
finally
{
//Console.WriteLine("Sum of digits of number is: {0}", result);
}
}
public static void Main()
{
Console.WriteLine("Enter a Number:");
string num = Console.ReadLine();
string numbers = num.Replace(@"\\", @",");
string[] values = numbers.Split(',');
AddNumbers add = new AddNumbers();
add.addition(values);
}
}
