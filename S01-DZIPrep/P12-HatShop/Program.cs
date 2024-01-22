using System;
using System.Collections.Generic;

namespace P12_HatShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HatShop> hatshops = new Dictionary<string, HatShop>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0]=="STOP")
                {
                    break;
                }
                string hatShopName = string.Empty;
                switch (input[0])
                {
                    case "CreateHatShop":
                        hatShopName = input[1];
                        HatShop hatShop = new HatShop(hatShopName);
                        hatshops.Add(hatShopName, hatShop);
                        Console.WriteLine($"You created hat shop {hatShopName}");
                        break;
                    case "AddHat":
                        string type = input[1];
                        string color = input[2];
                        double price = double.Parse(input[3]);
                        hatShopName = input[4];
                        Hat hat = new Hat(type, color, price);
                        hatshops[hatShopName].AddHat(hat);
                        Console.WriteLine($"You added hat {type} with color {color} to shop {hatShopName}.");
                        break;
                    case "SellHat":
                        hatShopName = input[4];
                        Hat hatS = new Hat(input[1], input[2], double.Parse(input[3]));
                        hatshops[hatShopName].SellHat(hatS);
                        Console.WriteLine($"You sold hat {hatS.Type} with color {hatS.Color} from hat shop {hatShopName}.");
                        break;
                    case "HatShopInfo":
                        hatShopName = input[1];
                        Console.WriteLine(hatshops[hatShopName].ToString()); 
                        break;
                    case "GetHatWithLowestPrice":
                        hatShopName= input[1];
                       Hat lowestPrice= hatshops[hatShopName].GetHatWithLowestPrice();
                        Console.WriteLine($"Hat from shop {hatShopName} has lowest price: {lowestPrice.Price:f2}");
                        break;
                    case "GetHatWithHighestPrice":
                        hatShopName = input[1];
                        Hat highestPrice = hatshops[hatShopName].GetHatWithHighestPrice();
                        Console.WriteLine($"Hat from shop {hatShopName} has highest price: {highestPrice.Price:f2}");
                        break;
                    case "CalculateTotalPrice":
                        hatShopName = input[1];
                        Console.WriteLine($"Total price: {hatshops[hatShopName].CalculateTotalPrice():f2}");
                        break;
                    case "RenameHatShop":
                        hatShopName = input[1];
                        string newName = input[2];
                        hatshops[hatShopName].RenameHatShop(newName);
                        hatshops.Add(newName, hatshops[hatShopName]);
                        Console.WriteLine($"You renamed your shop from {hatShopName} to {newName}.");
                        break;
                    case "SellAllHats":
                        hatShopName= input[1];
                        hatshops[hatShopName].SellAllHats();
                        Console.WriteLine($"You sold all hats from shop {hatShopName}.");
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }
        }
    }
}
