using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Context.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly WebAppContext _context;

        public MenuItemRepository(WebAppContext context)
        {
            _context = context;
        }

        public IEnumerable<MenuItem> GetAllItems()
        {
            return _context.MenuItems.Where(c => c.isUse == true).ToList();
        }

        public IEnumerable<MenuItem> GetAllMenuItems(int id)
        {
            return _context.MenuItems.Where(c => c.MenuId == id).ToList();
        }

        public MenuItem GetItem(int id)
        {
            return _context.MenuItems.FirstOrDefault(c => c.Id == id);
        }

        public void AddItem(MenuItem item)
        {
            _context.MenuItems.Add(item);
        }

        public void Update(int id, MenuItem item)
        {
            var target = _context.MenuItems.Find(id);
            if (target != null)
            {
                _context.MenuItems.Update(item);
            }
        }

        public void Delete(int id)
        {
            var target = _context.MenuItems.FirstOrDefault(c => c.Id == id);

            if (target != null)
            {
                _context.MenuItems.Remove(target);
            }
        }

        public void AddPayment(Payment payment)
        {
            Payment2 pay2 = new Payment2()
            {
                dateTime = payment.dateTime,
                paymentType = payment.paymentType,
                totalPrice = payment.totalPrice
            };
            _context.Payments.Add(pay2);

            foreach (var item in payment.menuItems)
            {
                PaymentList list = new PaymentList()
                {
                    dateTime = payment.dateTime,
                    mainId = item.Id,
                    MenuId = item.MenuId,
                    Name = item.Name,
                    ImagePath = item.ImagePath,
                    Price = item.Price,
                    isUse = item.isUse
                };

                _context.PaymentLists.Add(list);
            }
        }
            

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
