int firstNumber;
int secondNumber;
int temp;


Console.WriteLine("Enter first number");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
secondNumber = Convert.ToInt32(Console.ReadLine());

temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After swap: ");
Console.WriteLine("First number:" + firstNumber);
Console.WriteLine("Second number:" + secondNumber);
Console.Read();
