using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HatShop
{
    private  List<Hat> hats;
    private string name;

    public HatShop(string name)
    {
        this.Name = name;
        this.hats = new List<Hat>();
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length<6)
            {
                throw new ArgumentException("Invalid hat shop name!");
            }
            name = value;
        }
    }
    public void AddHat(Hat Hat)
    {
        hats.Add(Hat);
    }

    public bool SellHat(Hat Hat)
    {
        Hat hatToRemove = hats.Find(x=>x.Type == Hat.Type && x.Color == Hat.Color && x.Price == Hat.Price);
        if (hatToRemove != null)
        {
            hats.Remove(hatToRemove);
            return true;
        }

        return false;
    }

    public double CalculateTotalPrice()
    {
        return hats.Sum(x => x.Price);
    }

    public Hat GetHatWithHighestPrice()
    {
        return hats.OrderBy(x => x.Price).Last();
    }

    public Hat GetHatWithLowestPrice()
    {
        return hats.OrderBy(x => x.Price).FirstOrDefault();
    }

    public void RenameHatShop(string newName)
    {
        this.Name = newName;
    }

    public void SellAllHats()
    {
        hats.Clear();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (hats.Count > 0)
        {
            sb.AppendLine($"HatShop {Name} has {hats.Count} hat/s");
            hats.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
        return $"Hat shop {Name} has no available hats.";
    }

}

