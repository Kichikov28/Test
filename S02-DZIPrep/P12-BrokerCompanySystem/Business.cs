using System;
using System.Collections.Generic;
using System.Text;
public class Business : Building
{
    public Business(string name, string city, int stars, double rent) : base(name, city, stars, rent)
    {
        if (!name.EndsWith("Business"))
        {
            throw new ArgumentException("Name of business buildings should end on Business!");
        }
    }
}

