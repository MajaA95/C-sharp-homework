//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date


Console.WriteLine("Enter your birth date (MM/DD/YYYY):");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
string ageString = AgeCalculator(birthDate);
Console.WriteLine(ageString);


string AgeCalculator(DateTime birthdayDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthdayDate.Year;
    if (birthdayDate > today.AddYears(-age))
    {
        age--;
    }
    return "Your age is: " + age + " and your birth date is: " + birthdayDate;
}


