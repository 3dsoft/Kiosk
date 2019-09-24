using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class MenuItem
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int MenuId { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public bool isUse { get; set; }

    }
}
