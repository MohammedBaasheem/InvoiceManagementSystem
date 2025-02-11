using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core.ShoppingCarts
{
    internal abstract class ShoppingCart
    {
        private List<InvoiceLine> _Lines = new();
        public void AddItem(int itemId, double unitPrice, double quantity)
        {
            _Lines.Add(new InvoiceLine { ItemId = itemId, UnitPrice = unitPrice, Quantity = quantity });      
        }
        public void Checkout(Customer customer)
        {
            var invoice = new Invoice
            {
                Customer= customer,
                Lines = _Lines
            };

            ApplyTaxes(invoice);
            ApplyDiscount(invoice);
            ProcessPayment(invoice);
             

        }

        private void ApplyTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * 0.15;
        }

        protected abstract void ApplyDiscount(Invoice invoice);
        

        private void ProcessPayment(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice created for customer: {invoice.Customer.Name} with net price: {invoice.NetPrice}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
