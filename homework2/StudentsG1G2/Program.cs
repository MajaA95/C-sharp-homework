
Console.WriteLine("For G1 press 1, for G2 press 2");
string choice = Console.ReadLine();



string[] studentsG1 = new string[] { "Ana", "Marko", "Sara", "Marija", "Elena" };
string[] studentsG2 = new string[] { "Maja", "Zharko", "Borjan", "Slave", "David" };


switch (choice)
{
    case "1":
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
        break;

    case "2":
        foreach (string students in studentsG2)
        {
            Console.WriteLine(students);
        }
        break;
    default:
        Console.WriteLine("You can only choose 1 or 2");
        break;

}
Console.ReadLine();













