using System;
using System.Collections.Generic;
using System.Text;

public class Residence : Building
{
    public Residence(string name, string city, int stars, double rent) : base(name, city, stars, rent)
    {
        if (!name.EndsWith("Residence"))
        {
            throw new ArgumentException("Name of residence buildings should end on Residence!");
        }
    }
}

