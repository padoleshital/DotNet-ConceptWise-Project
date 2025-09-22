using System;

class Program
{
    static void Main(string[] args)
    {

        //string Name = "Shital";
        //Console.WriteLine($"Hello {Name}");
        //Console.WriteLine(Name.Length);
        //Console.WriteLine(Name);

        //////Giving one message to the user to enter his name
        //Console.WriteLine("Enter Your Name");
        //string name = Console.ReadLine();

        //Console.WriteLine($"Hello {name}");

        ////convert string into int
        //int Number1 = Convert.ToInt32(Console.ReadLine());

        //int Number2 = Convert.ToInt32(Console.ReadLine());

        //int Result = Number1 + Number2;
        //Console.WriteLine($"Result {Result}");
        //Console.WriteLine($"Sum is: {Number1 + Number2} ");

        //Background and Foreground color
        //Console.BackgroundColor = ConsoleColor.Blue;
        //Console.ForegroundColor = ConsoleColor.White;
        //Console.Title = "My First Console Project";
        //Console.WriteLine("BackgroundColor:blue");
        //Console.WriteLine("ForegroundColor:White");


        //Console.Beep();

        Console.WriteLine("Enter Employee Details");
        
        Console.WriteLine("Enter Employee ID");
        int EmployeeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name");
        string EmployeeName = Console.ReadLine();

        Console.WriteLine("Enter Employee Salary");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Address");
        string Address = Console.ReadLine();

        Console.WriteLine("Enter Employee Department");
        string Department = Console.ReadLine();

        Console.WriteLine("Employee Details As follows");
        Console.WriteLine($"Employee Id: {EmployeeId}");
        Console.WriteLine($"Employee Name: {EmployeeName}");
        Console.WriteLine($"Employee Salary:{salary}");
        Console.WriteLine($"Employee Address:{Address}");
        Console.WriteLine($"Employee Department:{Department}");

        Console.ReadKey();
    }
}



