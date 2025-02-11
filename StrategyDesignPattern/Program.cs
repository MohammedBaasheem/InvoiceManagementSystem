using StrategyDesignPattern.Core;
using StrategyDesignPattern.Core.DiscountStrategies;
using StrategyDesignPattern.Core.ShoppingCarts;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();
            var items = new ItemDataReader().GetItems();
            while (true)
            {
                Console.WriteLine("Customer List:");
                foreach (var Customer in customers) 
                {
                    Console.WriteLine($"\t {Customer.Id}.{Customer.Name}.{Customer.category}");
                }
                Console.WriteLine();

                Console.WriteLine("Item List");
                foreach(var Item in items)
                {
                    Console.WriteLine($"\t {Item.Id}.{Item.Name} ({Item.UnitPrice:0.00})");
                }
                Console.WriteLine();

                Console.Write("Enter customer Id: ");
                var customerId = int.Parse(Console.ReadLine());

                Console.Write("Select shopping Cart Type ( Online | InStore) : ");
                ShoppingCart shoppingcart=Console.ReadLine().Equals("Online",StringComparison.OrdinalIgnoreCase)?new OnlineShoppingCart(): new InStoreShoppingCart();


                while (true) 
                {
                    Console.Write("Enter Item ID (0 to copmlate order): ");
                    var itemId = int.Parse(Console.ReadLine());
                    if (itemId == 0)
                    {
                        break;
                    }
                    Console.Write("Enter Item Quantity: ");
                    var quantity = double.Parse(Console.ReadLine());
                     var item=items.First(i=>i.Id== itemId);
                    shoppingcart.AddItem(item.Id, item.UnitPrice, quantity);

                }

                var selectedCustomer = customers.First(c=>c.Id==customerId);



                shoppingcart.Checkout(selectedCustomer);


                Console.WriteLine("press any key to creat another invoice");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------------");


                //Console.Write("Enter Item Quantity: ");
                //var quantity=double.Parse(Console.ReadLine());
                //Console.Write("Enter Unit Price: ");
                //var unitPrice = double.Parse(Console.ReadLine());

                //var customer = customers.First(c => c.Id == customerId);
                //ICustomerDiscountStrategy customerDiscountStrategy=new CustomerDiscountStrategyFactory().CreatCustomerDiscountStrategy(customer.category);
                //var invoiceManager=new InvoiceManager();
                //invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
                //var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);
                //Console.WriteLine($"Invoice created for customer '{customer.Name}' with total price: {invoice.NetPrice} ");
                //Console.WriteLine("press any key to creat another invoice");
                //Console.ReadKey();
                //Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}
