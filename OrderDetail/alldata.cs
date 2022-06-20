
using Microsoft.EntityFrameworkCore;
using OrderDetail;
using OrderDetail.data;

namespace EntityFrameworkData
{
    public class alldata
    {
        private DemoDbContext demoDbContext;
        public alldata()
        {
            demoDbContext = new DemoDbContext();
        }
        public Items GetitemById(int customerID)
        {
            // Tracking not required
            var p = demoDbContext.items.Where(x => x.ID == customerID)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (p == null)
            {
                Console.WriteLine($"item with ID:{customerID} Not Found");
            }

            return p;
        }



        public List<Items> GetAllItems()
        {
            var items = demoDbContext.items.ToList();
            return items;
        }

        public void Insert(Items p)
        {
            demoDbContext.items.Add(p);
            demoDbContext.SaveChanges();
        }

        public void Update(int customer, Items modifieditem)
        {
            var item = demoDbContext.items.Where(x => x.ID == customer).FirstOrDefault();
            if (item == null)
            {
                throw new Exception($"item with ID:{customer} Not Found");
            }

            item.ItemName = modifieditem.ItemName;
            item.ItemRate = modifieditem.ItemRate;
            item.ItemQTY = modifieditem.ItemQTY;

            // Entity state : Modified
            demoDbContext.items.Update(item);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public void Delete(int customerID)
        {
            var item = demoDbContext.items.Where(x => x.ID == customerID).FirstOrDefault();
            if (item == null)
            {
                throw new Exception($"Employee with ID:{customerID} Not Found");
            }

            // Entity state : Deleted
            demoDbContext.items.Remove(item);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }
    }
}
