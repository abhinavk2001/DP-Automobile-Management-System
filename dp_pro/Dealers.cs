
public interface IDealers
{
    void PrintDealers();
}

public class ReadDealers
{
    public int Dealer_ID()
    {
        Console.WriteLine("What is the ID of the dealer?: ");
        int dealer_ID = int.Parse(Console.ReadLine());
        return dealer_ID;
    }
    public string Dealer_Name()
    {
        Console.WriteLine("What is the name of Dealer?: ");
        string dealer_Name = Console.ReadLine();
        return dealer_Name;
    }
    public int Dealer_Exp()
    {
        Console.Write("Number of years in automobile industry? ");
        int dealer_Exp = int.Parse(Console.ReadLine());
        return dealer_Exp;
    }
}

// Concrete dealer class
public class Dealers : IDealers
{
    private int Dealer_ID { get; set; }
    private string Dealer_Name { get; set; }
    private int Dealer_Exp { get; set; }

    public Dealers(int dealer_ID, string dealer_Name, int dealer_Exp)
    {
        Dealer_ID = dealer_ID;
        Dealer_Name= dealer_Name;
        Dealer_Exp= dealer_Exp;
    }

    public void PrintDealers()
    {
        Console.WriteLine($"Dealer ID: {Dealer_ID}");
        Console.WriteLine($"Name of Dealer: {Dealer_Name}");
        Console.WriteLine($"Experience: {Dealer_Exp}");
    }
}

// Base decorator class for dealer operations
public abstract class DealersDecorator : IDealers
{
    private IDealers dealers;

    public DealersDecorator(IDealers dealers)
    {
        this.dealers = dealers;
    }

    public virtual void PrintDealers()
    {
        dealers.PrintDealers();
    }
}
public class DealersFeeDecorator : DealersDecorator
{
    private decimal DealersFee { get; set; }

    public DealersFeeDecorator(IDealers dealers, decimal dealersFee) : base(dealers)
    {
        DealersFee = dealersFee;
    }

    public override void PrintDealers()
    {
        base.PrintDealers();
        Console.WriteLine($"Net revenue: {DealersFee}");
    }
}
// Main program class
public class Program5
{
    public void Main5()
    {

        /*ReadDealers obj5 = new ReadDealers();
                        int dealer_ID = obj5.Dealer_ID();
                        string dealer_Name = obj5.Dealer_Name();
                        int dealer_Exp = obj5.Dealer_Exp();

                        IDealers dealers = new Dealers(dealer_ID, dealer_Name, dealer_Exp);

                        Console.Write("Do you want to associate with us? (y/n): ");
                        string addFee5 = Console.ReadLine();
                        if (addFee5.ToLower() == "y")
                        {
                            Console.Write("Enter your net revenue for further processing: ");
                            decimal dealersFee = decimal.Parse(Console.ReadLine());
                            dealers = new DealersFeeDecorator(dealers, dealersFee);
                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("::::DEALER DETAILS::::");
                        Console.ResetColor();
                        dealers.PrintDealers();
    }*/
    }
}