
// Base interface for payment operations
public interface IPayment
{
    void MakePayment();
}

public class Read_Details
{
    public string Read_Type()
    {
        Console.Write("Enter Payment Type: ");
        string paymentType = Console.ReadLine();
        return paymentType;
    }
    public int Read_ID()
    {
        Console.Write("Enter Payment ID: ");
        int paymentId = int.Parse(Console.ReadLine());
        return paymentId;
    }
    public DateTime Read_Date()
    {
        Console.Write("Enter Payment Date (yyyy-mm-dd): ");
        DateTime paymentDate = DateTime.Parse(Console.ReadLine());
        return paymentDate;
    }
    public string Read_Status()
    {
        Console.Write("Enter Payment Status: ");
        string paymentStatus = Console.ReadLine();
        return paymentStatus;

    }
    public decimal Read_Amount()
    {
        Console.Write("Enter Payment Amount: ");
        decimal paymentAmount = decimal.Parse(Console.ReadLine());
        return paymentAmount;

    }
}

// Concrete payment class
public class Payment : IPayment
{
    private string PaymentType { get; set; }
    private int PaymentId { get; set; }
    private DateTime PaymentDate { get; set; }
    private string PaymentStatus { get; set; }
    private decimal PaymentAmount { get; set; }

    public Payment(string paymentType, int paymentId, DateTime paymentDate, string paymentStatus, decimal paymentAmount)
    {
        PaymentType = paymentType;
        PaymentId = paymentId;
        PaymentDate = paymentDate;
        PaymentStatus = paymentStatus;
        PaymentAmount = paymentAmount;
    }

    public void MakePayment()
    {
        Console.WriteLine($"Payment Type: {PaymentType}");
        Console.WriteLine($"Payment ID: {PaymentId}");
        Console.WriteLine($"Payment Date: {PaymentDate}");
        Console.WriteLine($"Payment Status: {PaymentStatus}");
        Console.WriteLine($"Payment Amount: {PaymentAmount}");
    }
}

// Base decorator class for payment operations
public abstract class PaymentDecorator : IPayment
{
    private IPayment payment;

    public PaymentDecorator(IPayment payment)
    {
        this.payment = payment;
    }

    public virtual void MakePayment()
    {
        payment.MakePayment();
    }
}

// Concrete decorator class for adding payment fee
public class PaymentFeeDecorator : PaymentDecorator
{
    private decimal PaymentFee { get; set; }

    public PaymentFeeDecorator(IPayment payment, decimal paymentFee) : base(payment)
    {
        PaymentFee = paymentFee;
    }

    public override void MakePayment()
    {
        base.MakePayment();
        Console.WriteLine($"Payment Fee: {PaymentFee}");
    }
}

// Main program class
public class Program1
{
    public void Main1()
    {

        /*Read_Details obj1 = new Read_Details();
        string paymentType = obj1.Read_Type();
        int paymentId = obj1.Read_ID();
        DateTime paymentDate = obj1.Read_Date();
        string paymentStatus = obj1.Read_Status();
        decimal paymentAmount = obj1.Read_Amount();

        IPayment payment = new Payment(paymentType, paymentId, paymentDate, paymentStatus, paymentAmount);

        Console.Write("Do you want to add payment fee? (y/n): ");
        string addFee = Console.ReadLine();

        if (addFee.ToLower() == "y")
        {
            Console.Write("Enter Payment Fee: ");
            decimal paymentFee = decimal.Parse(Console.ReadLine());
            payment = new PaymentFeeDecorator(payment, paymentFee);
        }

        Console.WriteLine("Payment Details:");
        payment.MakePayment();
    }*/
    }
}