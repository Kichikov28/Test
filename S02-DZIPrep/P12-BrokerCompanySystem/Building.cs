using System;
using System.Collections.Generic;
using System.Text;

public abstract class Building
{
    private string name;
    private string city;
    private int stars;
    private double rentamount;

    protected Building(string name, string city, int stars, double rent)
    {
        this.Name = name;
        this.City = city;
        this.Stars = stars;
        this.RentAmount = rent;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Building name must not be null or empty!");
            }
            name = value;
        }
    }
    public string City
    {
        get { return city; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("City must not be null or empty!");
            }
            city = value;
        }
    }
    public int Stars
    {
      
        get { return stars; }
        set
        {
            if (value<0 ||value>5)
            {
                throw new ArgumentException("Stars cannot be less than 0 or above 5!");
            }
            stars = value;
        }
    }
    public double RentAmount
    {
        get { return rentamount; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Rent amount cannot be less or equal to 0!");
            }
            rentamount= value;
        }
    }
    public bool IsAvailable { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"****Building: {Name} <{Stars}>");
        sb.AppendLine($"****Location: {City}");
        sb.AppendLine($"****RentAmount: {RentAmount}");
        sb.AppendLine($"****Is Available: {IsAvailable}");
        return sb.ToString().TrimEnd();
    }
}

