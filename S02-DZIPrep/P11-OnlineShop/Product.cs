using System;
using System.Collections.Generic;
using System.Text;

namespace P11_OnlineShop
{
    public abstract class Product
    {
        private int id;
        private string manufacturer;
        private string model;
        private decimal price;
        private double overallPerformance;

        public Product(int id, string manufacturer, string model, decimal price, double overallPerformance)
        {
            this.Id = id;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.OverallPerformance = overallPerformance;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Id can not be less or equal than 0.");
                }
                id = value;
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer can not be empty.");
                }
                manufacturer = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model can not be empty.");
                }
                model = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price can not be less or equal than 0.");
                }
                price = value;
            }
        }
        public double OverallPerformance
        {
            get { return overallPerformance; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Overall Performance can not be less or equal than 0");
                }
                overallPerformance = value;
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance}. Price: {Price} - {{product type}}: {Manufacturer} {Model} (Id: {id})"; 
        }
    }
}
