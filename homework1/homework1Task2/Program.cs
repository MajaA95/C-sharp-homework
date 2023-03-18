double firstNumber;
double secondNumber;
double thirdNumber;
double fourthNumber;
double result;



Console.WriteLine("Enter the First number");
firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Second number");
secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Third number");
thirdNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Fourth number");
fourthNumber = Convert.ToDouble(Console.ReadLine());

result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
Console.WriteLine("The average of numbers is:" + result);
Console.ReadLine();


