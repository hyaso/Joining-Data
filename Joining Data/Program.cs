using System;
using System.Collections.Generic;
using System.Linq;

namespace Joining_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating array of CustomerOrders
            CustomerOrder[] sampleOrders = new CustomerOrder[]
            {
                new CustomerOrder() {CustomerName="Acme Hardware", Item="Mouse", Price=25, Quantity=3 },
                new CustomerOrder() {CustomerName="Acme Hardware", Item="Keyboard", Price=45, Quantity=2 },
                new CustomerOrder() {CustomerName = "Falls Realty", Item = "Macbook", Price = 800, Quantity = 2 },
                new CustomerOrder() {CustomerName= "Julie’s Morning Diner", Item="iPad", Price=525, Quantity=1 },
                new CustomerOrder() {CustomerName = "Julie’s Morning Diner", Item = "Credit Card Reader", Price = 45, Quantity = 1 }
            };

            var sampleOrdersGroupedByCustomer = sampleOrders.GroupBy(x => x.CustomerName).ToArray();
            var columnName1 = "CustomerName";
            var columnName2 = "Item";
            var columnName3 = "Price";
            var columnName4 = "Quantity";
            Console.WriteLine($"{columnName1:20} {columnName2:10} {columnName3:10} {columnName4:20}");
            foreach (var currCustomerGroup in sampleOrdersGroupedByCustomer)
            {
                Console.WriteLine($"{currCustomerGroup.Key}");
                foreach (var currOrder in currCustomerGroup)
                {
                    decimal total = currOrder.Price * currOrder.Quantity;
                    Console.WriteLine($"    {currOrder.Item} ${currOrder.Price} {currOrder.Quantity} == ${total}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Exercise 3");
            //so the next problem is:
            //  1. print out customer name AND the first item.
            //  2. then print out every OTHER item
            foreach (var currGroup in sampleOrdersGroupedByCustomer)
            {
                var currGroupOrdersArray = currGroup.ToArray();
                Console.WriteLine($"{currGroup.Key}     {currGroupOrdersArray[0].Item}  {currGroupOrdersArray[0].Price} {currGroupOrdersArray[0].Quantity}");
                var currGroupOrdersExceptFirstArray = currGroupOrdersArray.Skip(1);
                foreach (var currOrder in currGroupOrdersExceptFirstArray)
                {
                    decimal total = currOrder.Price * currOrder.Quantity;
                    Console.WriteLine($"    {currOrder.Item} ${currOrder.Price} {currOrder.Quantity} == ${total}");
                }

            }
        }
    }
}
