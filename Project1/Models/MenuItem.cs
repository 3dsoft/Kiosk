namespace Project1.Models
{
    public class MenuItem
    {
        public long Id { get; set; }

        public int MenuId { get; set; }

        public string ImagePath { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public bool isUse { get; set; }
    }
}
