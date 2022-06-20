
using DocumentFormat.OpenXml.VariantTypes;
using EntityFrameworkData;

using Microsoft.EntityFrameworkCore;
using OrderDetail;
using OrderDetail.data;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            alldata obj = new alldata();

            Console.WriteLine("Adding a new item");
            obj.Insert(new Items { ItemName = "pizza", ItemRate = 500, ItemQTY=5 });
            obj.Insert(new Items { ItemName = "momos", ItemRate = 500, ItemQTY = 5 });
            PrintAllitems();

            //Console.WriteLine("Updating Items with customerID 2");
            //obj.Update(2, new Employee { Name = "Modified Items", ItemRate = "Modified ItemRate",ItemQTY="Modified ItemQTY" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Item details for customerID 2");
            //var employee = obj.GetitemById(2);
            //Console.WriteLine($"Item Name of item ID 2 is {item.Name}");

            //Console.WriteLine("Deleting Items details for customer 2");
            //obj.Delete(2);
            //PrintAllItem();

            Console.ReadLine();
        }

        private static void PrintAllitems()
        {
            Console.WriteLine("Printing all items");
            alldata obj = new alldata();
            foreach (Items? item in obj.GetAllItems())
            {
                Console.WriteLine($"Items Name is {item.ItemName} and Rate is {item.ItemRate}");
            }
        }
    }
}