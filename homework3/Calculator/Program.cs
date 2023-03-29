
int Main ()
{

    Console.WriteLine("Enter operator");
    char op = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Enter number 1");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter number 2");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int result = 0;

    switch (op)

    {

        case '+':
            result = Sum(number1, number2);
            break;

        case '-':
            result = Substract(number1, number2);
            break;

        case '*':
            result = Multiply(number1, number2);
            break;

        case '/':
            try
            {
                result = Divide(number1, number2);
            }
            catch (DivideByZeroException caught) {
                Console.WriteLine("Exception caught: {0}", caught);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
            break;

        default:
            Console.WriteLine("You entered invalid operator");
            break;

    }
    return result;
    }


    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    int Substract(int num1, int num2)
    {
        return num1 - num2;
    }
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    int Divide(int num1, int num2)
    {
        return num1 / num2;
    }


int res = Main();
Console.WriteLine("The result is: " + res);
Console.ReadLine();

