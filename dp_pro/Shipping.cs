
// Base interface for shipping operations
public interface IShipping
{
    void PrintValues();
}

public class Read_Values
{
    public int Shipping_ID()
    {
        Console.Write("Enter Shipping ID: ");
        int shipping_ID = int.Parse(Console.ReadLine());
            return shipping_ID;
    }
    public string Item_Name()
    {
        Console.Write("Enter Item Name: ");
        string item_Name = Console.ReadLine();
        return item_Name;
    }
    public int S_Cost()
    {
        Console.Write("Enter Shipping Cost: ");
        int s_Cost = int.Parse(Console.ReadLine());
        return s_Cost;
    }
}

// Concrete shipping class
public class Shipping : IShipping
{
    private int Shipping_ID { get; set; }
    private string Item_Name { get; set; }
    private int S_Cost { get; set; }

    public Shipping(int shipping_ID, string item_Name, int s_Cost)
    {
        Shipping_ID = shipping_ID;
        Item_Name = item_Name;
        S_Cost = s_Cost;
    }

    public void PrintValues()
    {
        Console.WriteLine($"Shipping ID: {Shipping_ID}");
        Console.WriteLine($"Item name to be shipped: {Item_Name}");
        Console.WriteLine($"Shipping cost: {S_Cost}");
    }
}

// Base decorator class for shipping operations
public abstract class ShippingDecorator : IShipping
{
    private IShipping shipping;

    public ShippingDecorator(IShipping shipping)
    {
        this.shipping = shipping;
    }

    public virtual void PrintValues()
    {
        shipping.PrintValues();
    }
}
public class ShippingFeeDecorator : ShippingDecorator
{
    private decimal ShippingFee { get; set; }

    public ShippingFeeDecorator(IShipping shipping, decimal shippingFee) : base(shipping)
    {
        ShippingFee = shippingFee;
    }

    public override void PrintValues()
    {
        base.PrintValues();
        Console.WriteLine($"Additional Shipping Fee: {ShippingFee}");
    }
}
// Main program class
public class Program2
{
    public void Main2()
    {

        /*Read_Values obj2 = new Read_Values();
                    int shipping_ID = obj2.Shipping_ID();
                    string item_Name = obj2.Item_Name();
                    int s_Cost = obj2.S_Cost();

                    IShipping shipping = new Shipping(shipping_ID, item_Name, s_Cost);

                    Console.Write("Do you want to add shipping fee? (y/n): ");
                    string addFee2 = Console.ReadLine();
                    if (addFee2.ToLower() == "y")
                    {
                        Console.Write("Enter Additional Shipping Fee: ");
                        decimal shippingFee = decimal.Parse(Console.ReadLine());
                        shipping = new ShippingFeeDecorator(shipping, shippingFee);
                    }
                    Console.WriteLine("Shipping Details:");
                    shipping.PrintValues();
    }*/
    }
}