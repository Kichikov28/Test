using System;
using System.Collections.Generic;
using System.Text;
public class ParkingSpot
{
    private double price;
    private List<ParkingInterval> parkingIntervals;

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }
    public void AddInterval(ParkingInterval interval)
    {
        this.parkingIntervals.Add(interval);
    }

    public IReadOnlyList<ParkingInterval> ParkingIntervals
    {
        get { return this.parkingIntervals; }
    }
    public int Id { get; set; }
    public bool Occupied { get; set; }
    public string Type { get; set; }
    public double Price
    {
        get { return price; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            }
            price = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"> Parking Spot #{Id}");
        sb.AppendLine($"> Occupied: {Occupied}");
        sb.AppendLine($"> Type: {Type}");
        sb.AppendLine($"> Price per hour: {Price:F2} BGN");
        return sb.ToString().TrimEnd(); 
    }
}
