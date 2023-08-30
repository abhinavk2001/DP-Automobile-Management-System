
// Base interface for parts operations
public interface IParts
{
    void PrintData();
}

public class ReadData
{
    public int Parts_ID()
    {
        Console.Write("Enter Parts ID: ");
        int parts_ID = int.Parse(Console.ReadLine());
        return parts_ID;
    }
    public string Parts_Name()
    {
        Console.Write("Enter Name of the parts: ");
        string parts_Name = Console.ReadLine();
        return parts_Name;
    }
    public int Parts_Cost()
    {
        Console.Write("Enter Parts Cost: ");
        int parts_Cost = int.Parse(Console.ReadLine());
        return parts_Cost;
    }
}

// Concrete parts class
public class Parts : IParts
{
    private int Parts_ID { get; set; }
    private string Parts_Name { get; set; }
    private int Parts_Cost { get; set; }

    public Parts(int parts_ID, string parts_Name, int parts_Cost)
    {
        Parts_ID = parts_ID;
        Parts_Name = parts_Name;
        Parts_Cost = parts_Cost;
    }

    public void PrintData()
    {
        Console.WriteLine($"Parts ID: {Parts_ID}");
        Console.WriteLine($"Name of the parts: {Parts_Name}");
        Console.WriteLine($"Cost of the parts: {Parts_Cost}");
    }
}

// Base decorator class for parts operations
public abstract class PartsDecorator : IParts
{
    private IParts parts;

    public PartsDecorator(IParts parts)
    {
        this.parts = parts;
    }

    public virtual void PrintData()
    {
        parts.PrintData();
    }
}
public class PartsFeeDecorator : PartsDecorator
{
    private decimal PartsFee { get; set; }

    public PartsFeeDecorator(IParts parts, decimal partsFee) : base(parts)
    {
        PartsFee = partsFee;
    }

    public override void PrintData()
    {
        base.PrintData();
        Console.WriteLine($"Additional Fee for parts: {PartsFee}");
    }
}
// Main program class
public class Program3
{
    public void Main3()
    {

        /*ReadData obj3 = new ReadData();
                    int parts_ID = obj3.Parts_ID();
                    string parts_Name = obj3.Parts_Name();
                    int parts_Cost = obj3.Parts_Cost();

                    IParts parts = new Parts(parts_ID, parts_Name, parts_Cost);

                    Console.Write("Do you want to add express delivery fee? (y/n): ");
                    string addFee3 = Console.ReadLine();
                    if (addFee3.ToLower() == "y")
                    {
                        Console.Write("Enter Additional Fee: ");
                        decimal partsFee = decimal.Parse(Console.ReadLine());
                        parts = new PartsFeeDecorator(parts, partsFee);
                    }
                    Console.WriteLine("Parts Details:");
                    parts.PrintData();
    }*/
    }
}