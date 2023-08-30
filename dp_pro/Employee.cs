
// Base interface for employee operations
using System.Xml.Linq;

public interface IEmployee
{
    void PrintDetails();
}

public class ReadDetails
{
    public string Read_Name()
    {
        Console.WriteLine("What is name of the employee: ");
        string read_Name = Console.ReadLine();
        return read_Name;
    }
    public string Read_Area()
    {
        Console.WriteLine("What is Area of Work: ");
        string read_Area = Console.ReadLine();
        return read_Area;
    }
    public string Read_Post()
    {
        Console.Write("What is the position of work: ");
        string read_Post = Console.ReadLine();
        return read_Post;
    }
}

// Concrete employee class
public class Employee : IEmployee
{
    private string Read_Name { get; set; }
    private string Read_Area{ get; set; }
    private string Read_Post { get; set; }

    public Employee(string read_Name, string read_Area, string read_Post)
    {
        Read_Name = read_Name;
        Read_Area = read_Area;
        Read_Post = read_Post;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name of the employee: {Read_Name}");
        Console.WriteLine($"Area: {Read_Area}");
        Console.WriteLine($"Position: {Read_Post}");
    }
}

// Base decorator class for employee operations
public abstract class EmployeeDecorator : IEmployee
{
    private IEmployee employee;

    public EmployeeDecorator(IEmployee employee)
    {
        this.employee = employee;
    }

    public virtual void PrintDetails()
    {
        employee.PrintDetails();
    }
}
public class EmployeeFeeDecorator : EmployeeDecorator
{
    private decimal EmployeeFee { get; set; }

    public EmployeeFeeDecorator(IEmployee employee, decimal employeeFee) : base(employee)
    {
        EmployeeFee = employeeFee;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Total tenure of job: {EmployeeFee}");
    }
}
// Main program class
public class Program4
{
    public void Main4()
    {

        /*ReadDetails obj4 = new ReadDetails();
                    string read_Name = obj4.Read_Name();
                    string read_Area = obj4.Read_Area();
                    string read_Post = obj4.Read_Post();

                    IEmployee employee = new Employee(read_Name, read_Area, read_Post);

                    Console.Write("Do you want to continue your application (y/n): ");
                    string addFee4 = Console.ReadLine();
                    if (addFee4.ToLower() == "y")
                    {
                        Console.Write("Enter number of years you wish to continue: ");
                        decimal employeeFee = decimal.Parse(Console.ReadLine());
                        employee = new EmployeeFeeDecorator(employee, employeeFee);
                    }
                    Console.WriteLine("Employee Details:");
                    employee.PrintDetails();s
    }*/
    }
}