int sum = 0;

Console.WriteLine("Enter 6 numbers");

int[] integers = new int[6];

for(int i=0; i<integers.Length;i++)
{
    Console.WriteLine("Enter number " + (i+1) + ": ");
    integers[i] = Convert.ToInt32(Console.ReadLine());
    
}

//for(int i =0; i< 6; i++) //Another way
//{
//    Console.WriteLine("Enter number "+i+": ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    if ( number % 2 == 0)
//    { sum+= number; }

//}

foreach (int i in integers)
{
    if (i % 2 == 0)
    {
        sum += i;
    }

}

Console.WriteLine("Sum of the even numbers is: " + sum);
Console.ReadLine();


