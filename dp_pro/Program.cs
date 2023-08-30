using System;
namespace exp
{
    class Program
    {
        public static void Main()
        {
        Loop:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("::::::::::::::::::::::::");
            Console.WriteLine("AUTOMOBILE MANAGEMENT SYSTEM");
            Console.WriteLine("::::::::::::::::::::::::");
            Console.ResetColor();   
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Payment");
            Console.WriteLine("2. Shipping");
            Console.WriteLine("3. Parts");
            Console.WriteLine("4. Employee");
            Console.WriteLine("5. Dealers");

            Console.Write("Enter the domain you wish to explore: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            string repeat;
               
                switch (choice)
                {

                    case 1:
                        Read_Details obj1 = new Read_Details();
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("::::PAYMENT DETAILS::::");
                        Console.ResetColor();
                        payment.MakePayment();
                        break;

                    case 2:
                        Read_Values obj2 = new Read_Values();
                        int shipping_ID = obj2.Shipping_ID();
                        string item_Name = obj2.Item_Name();
                        int s_Cost = obj2.S_Cost();

                        IShipping shipping = new Shipping(shipping_ID, item_Name, s_Cost);

                        Console.Write("Do you want to add high-priority shipping? (y/n): ");
                        string addFee2 = Console.ReadLine();
                        if (addFee2.ToLower() == "y")
                        {
                            Console.Write("Enter Additional Shipping Fee: ");
                            decimal shippingFee = decimal.Parse(Console.ReadLine());
                            shipping = new ShippingFeeDecorator(shipping, shippingFee);
                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("::::SHIPPING DETAILS::::");
                        Console.ResetColor();
                        shipping.PrintValues();
                        break;

                    case 3:
                        ReadData obj3 = new ReadData();
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("::::PARTS DETAILS::::");
                        Console.ResetColor();
                        parts.PrintData();
                        break;
                    case 4:
                        ReadDetails obj4 = new ReadDetails();
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("::::EMPLOYEE DETAILS::::");
                        Console.ResetColor();
                        employee.PrintDetails();
                        break;
                    case 5:
                        ReadDealers obj5 = new ReadDealers();
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
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("Would you like to go to other domains?(y/n): ");
                repeat = Console.ReadLine();
                if (repeat.ToLower() == "y")
                {
                    goto Loop;
                }
            else if (repeat.ToLower() == "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---HAVE A NICE DAY---");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}