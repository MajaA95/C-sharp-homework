//Create a function that takes a number as input. This method should return the sum of the digits in the number.


Console.WriteLine("Enter a number");
int inputedNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumOfDigits(inputedNumber));


int sumOfDigits(int digits)
{
    int sum = 0;
    string digitString = Convert.ToString(digits);

    char[] Chars = digitString.ToCharArray();

    foreach (char characters in Chars)
    {
    
        int digit = (int)Char.GetNumericValue(characters);
        sum += digit;
    }
    return sum;
}

