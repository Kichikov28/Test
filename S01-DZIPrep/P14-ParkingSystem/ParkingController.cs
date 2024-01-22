using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ParkingController
{
    private Dictionary<int, ParkingSpot> parkingSpots = new Dictionary<int, ParkingSpot>();
    public string CreateParkingSpot(List<string> args)
    {
        ParkingSpot parkingSpot = null;
        int id = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);
        if (type == "subscription")
        {
            string registrationPlate = args[4];
            parkingSpot = new SubscriptionParkingSpot(id, occupied, price, registrationPlate);
        }
        else if (type == "car")
        {
            parkingSpot = new CarParkingSpot(id, occupied, price);
        }
        else if (type == "bus")
        {
            parkingSpot = new BusParkingSpot(id, occupied, price);
        }
        else
        {
            return $"Unable to create parking spot!";
        }
        if (parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} is already registered!";
        }
        parkingSpots.Add(id, parkingSpot);
        return $"Parking spot {id} was successfully registered in the system!";
    }
    public string ParkVehicle(List<string> args)
    {
        int id = int.Parse(args[0]);
        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];
        if (!parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} not found!";
        }
        if (parkingSpots[id].Occupied || parkingSpots[id].Type != type)
        {
            return $"Vehicle {registrationPlate} can't park at {id}.";
        }
        parkingSpots[id].AddInterval(new ParkingInterval(parkingSpots[id], registrationPlate, hoursParked));
        return $"Vehicle {registrationPlate} parked at {id} for {hoursParked} hours.";
    }
    public string FreeParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (!parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} not found! ";
        }
        if (!parkingSpots[id].Occupied)
        {
            return $"Parking spot {id} is not occupied.";
        }
        parkingSpots[id].Occupied = false;
        return $"Parking spot {id} is now free!";
    }
    public string GetParkingSpotById(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (!parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} not found! ";
        }
        return parkingSpots[id].ToString();
    }
    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        int id = int.Parse(args[0]);
        string regisrationPlate = args[1];
        if (!parkingSpots.ContainsKey(id))
        {
            return $"Parking spot {id} not found! ";
        }
        List<ParkingInterval> parkingIntervals = parkingSpots[id]
            .ParkingIntervals
            .Where(x => x.RegistrationPlate == regisrationPlate)
            .ToList();
        StringBuilder sb = new StringBuilder();
        parkingIntervals.ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString().TrimEnd();
    }
    public string CalculateTotal()
    {
        double sum = parkingSpots.Values.Sum(x => x.ParkingIntervals.Sum(x => x.Revenue));
        return $"Total revenue from the parking: {sum:F2} BGN";

    }
}

