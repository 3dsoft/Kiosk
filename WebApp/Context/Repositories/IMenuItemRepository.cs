﻿using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Context.Repositories
{
    public interface IMenuItemRepository
    {
        void AddItem(MenuItem item);
        void Delete(int id);
        IEnumerable<MenuItem> GetAllItems();
        IEnumerable<MenuItem> GetAllMenuItems(int id);
        MenuItem GetItem(int id);
        void Save();
        void Update(int id, MenuItem item);

        void AddPayment(Payment payment);
    }
}