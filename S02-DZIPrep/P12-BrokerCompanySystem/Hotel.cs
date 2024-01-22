using System;
using System.Collections.Generic;
using System.Text;
public class Hotel : Building
{
    public Hotel(string name, string city, int stars, double rent) : base(name, city, stars, rent)
    {
        if (!name.EndsWith("Hotel"))
        {
            throw new ArgumentException("Name of hotel buildings should end on Hotel!");
        }
    }
}

