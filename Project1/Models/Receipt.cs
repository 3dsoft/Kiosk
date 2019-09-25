using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Receipt
    {
        static Receipt receipt;
        List<MenuItem> menuItems = new List<MenuItem>();

        private Receipt() { receipt = this; }

        public static Receipt GetReceipt()
        {
            if (receipt == null) receipt = new Receipt();

            return receipt;
        }

        public List<MenuItem> GetReceipts()
        {
            return menuItems;
        }

        public MenuItem GetReceipt(long id)
        {
            return menuItems.Where(c => c.Id == id).FirstOrDefault();
        }

        public void AddReceipt(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public void RemoveReceipt(MenuItem menuItem)
        {
            menuItems.Remove(menuItem);
        }

        public void RemoveReceipt(long id)
        {
            menuItems.Remove(menuItems.Where(c => c.Id == id).FirstOrDefault());
        }


        public int GetTotalPrice()
        {
            int total = 0;

            foreach (MenuItem item in menuItems)
            {
                total += item.Price;
            }

            return total;
        }

    }
}
