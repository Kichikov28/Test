using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ParkingInterval
{
    private double revenue;
    private string registrationPlate;
    private int hoursParked;

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        this.ParkingSpot = parkingSpot;
        this.RegistrationPlate = registrationPlate;
        this.HoursParked = hoursParked;
    }

    public ParkingSpot ParkingSpot { get; set; }
    public string RegistrationPlate
    {
        get { return registrationPlate; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Registration plate can’t be null or empty!");
            }
            registrationPlate = value;
        }
    }
    public int HoursParked
    {
        get { return hoursParked; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Hours parked can’t be zero or negative!");
            }
            hoursParked = value;
        }
    }
    public double Revenue
    {
        get
        {
            if (ParkingSpot.Type=="subscription")
            {
                return 0;
            }
            return ParkingSpot.Price* HoursParked;
        }
    }
    public bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (ParkingSpot.Occupied||ParkingSpot.Type!=type)
        {
            return false ;
        }
        ParkingSpot.AddInterval(new ParkingInterval(ParkingSpot,registrationPlate, hoursParked));
        return true;
    }
    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return ParkingSpot.ParkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }
    public double CalculateTotal()
    {
        return ParkingSpot.ParkingIntervals.Sum(x => x.Revenue);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"> ParkingSpot #{ParkingSpot.Id}");
        sb.AppendLine($"> HoursParked: {HoursParked} hours");
        sb.AppendLine($"> Revenue: {Revenue} BGN");
        sb.AppendLine($"");

        return sb.ToString().TrimEnd();
    }
}

