using System.Data.Common;

double firstNumber;
double secondNumber;
double result;
char operation;

Console.WriteLine("Enter first number");
firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
secondNumber = double.Parse(Console.ReadLine());   

Console.WriteLine("Enter the operator");
operation = char.Parse(Console.ReadLine());


if(operation == '+')
{
    result = firstNumber + secondNumber;
    Console.WriteLine(result);
}
if(operation == '-')
{
    result = firstNumber - secondNumber;
    Console.WriteLine(result);
}
if(operation == '/')
{
    result = firstNumber / secondNumber;
    Console.WriteLine(result);
}
if(operation == '*')
{
    result = firstNumber * secondNumber;
    Console.WriteLine(result);
}
Console.ReadLine();


                    
