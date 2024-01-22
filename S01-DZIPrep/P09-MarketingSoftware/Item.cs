using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P09_MarketingSoftware
{
    public class Item
    {
        private int id;
        private string name;
        private decimal price;
        private int quantity;
        private int itemType;

        public Item(int id, string name, decimal price, int quantity, int itemType)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.ItemType = itemType;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [MaxLength(20)]
        [MinLength(2)]
        public string Name
        {
            get { return name; }
            set{ name = value;}
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        public decimal TotalValue()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Id}, {Name}, {Price:f2} lv., {Quantity} broya, {ItemType} tip, {Id+Name.Substring(0,2)+ItemType}");
            return sb.ToString(); 
        }


    }
}
