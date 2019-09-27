using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PaymentList
    {
        [Key]
        public int Id { get; set; }

        public DateTime dateTime { get; set; }

        //public List<MenuItem> menuItems { get; set; }


        public long mainId { get; set; }

        public int MenuId { get; set; }

        public string ImagePath { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public bool isUse { get; set; }

    }
}
