using System;
using System.Collections.Generic;
using System.Text;

public class SubscriptionParkingSpot : ParkingSpot
{
    private string registrationPlate;

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
    {
        this.RegistrationPlate = registrationPlate;
    }
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
}

