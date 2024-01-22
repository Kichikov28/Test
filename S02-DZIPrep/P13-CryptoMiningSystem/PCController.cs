using P13_CryptoMiningSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PCController
{
    public Dictionary<string,User> users=new Dictionary<string,User>();
    public string RegisterUser(List<string> args)
    {
        string name = args[1];
        double money = double.Parse(args[2]);
        if (users.ContainsKey(name))
        {
            return $"Username: {name} already exists!";
        }
        User user = new User() { Name=name,Money=money};
        users.Add(name, user);
        return $"Successfully registered user – {name}!";
    }
    public string CreateComputer(List<string> args)
    {
        string name = args[1];
        string processorType = args[2];
        string processorModel = args[3];
        int processorGeneration = int.Parse(args[4]);
        double processorPrice = double.Parse(args[5]);
        string videoCardType = args[6];
        string videoCardModel = args[7];
        int videoCardGeneration = int.Parse(args[8]);
        int videoCardRam = int.Parse(args[9]);
        double videoCardPrice = double.Parse(args[10]);
        int ram = int.Parse(args[11]);
       
        if (!users.ContainsKey(name))
        {
            return $"Username: {name} does not exist!";
        }
        if (processorType != "High" && processorType != "Low")
        {
            return "Invalid type processor!";
        }
        if (videoCardType != "Game" && videoCardType != "Mine")
        {
            return "Invalid type video card!";
        }
        if (users[name].Money < (processorPrice+videoCardPrice))
        {
            return $"User: {name} - insufficient funds!";
        }
        Processor processor = null;
        switch (processorType)
        {
            case "High":
                processor = new HighPerformanceProcessor() {Model=processorModel,Price=processorPrice,Generation=processorGeneration };
                break;
            case "Low":
                processor = new LowPerformanceProcessor() { Model = processorModel, Price = processorPrice, Generation = processorGeneration };
                break;
        }
        VideoCard videoCard = null;
        switch (videoCardType)
        {
            case "Mine":
                videoCard = new MineVideoCard() { Model=videoCardModel, Price = videoCardPrice,Generation = videoCardGeneration,Ram=videoCardRam};
                break;
            case "Game":
                videoCard = new MineVideoCard() { Model = videoCardModel, Price = videoCardPrice, Generation = videoCardGeneration,Ram=videoCardRam };
                break;
        }
        Computer computer = new Computer() { Processor=processor,VideoCard=videoCard,Ram=ram};
        users[name].Computer=computer;
        return $"Successfully created computer for user: {name}!";
    }
    public string Mine()
    {
        double sumMined = 0;
        foreach (var user in users)
        {
            if (user.Value.Computer != null)
            {
                sumMined += user.Value.Computer.MinedAmountPerHour * 24;
            user.Value.Computer.Processor.LifeWorkingHours -= 24;
            user.Value.Computer.VideoCard.LifeWorkingHours -= 24;
            user.Value.Money += sumMined;
            }
            
        }
        return $"Daily profits: {sumMined}!";

    }
    public string UserInfo(List<string> args)
    {
        string name = args[1];

        if (users.ContainsKey(name))
        {
            User user = users[name];

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {name} - Stars: {user.Stars}");
            sb.AppendLine($"Balance: {user.Money}");

            if (user.Computer != null)
            {
                sb.AppendLine($"PC Ram: {user.Computer.Ram}");

                if (user.Computer.Processor != null)
                {
                    sb.AppendLine($"- Processor: {user.Computer.Processor.GetType().Name} – {user.Computer.Processor.Model} – {user.Computer.Processor.Generation}");
                }

                if (user.Computer.VideoCard != null)
                {
                    sb.AppendLine($"- Video Card: {user.Computer.VideoCard.GetType().Name} – {user.Computer.VideoCard.Model} – {user.Computer.VideoCard.Generation}");
                    sb.AppendLine($"  * Video card Ram: {user.Computer.VideoCard.Ram}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        return $"Username: {name} does not exist!";
    }

    public string Shutdown()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var user in users)
        {
            sb.AppendLine($"Name: {user.Value.Name} - Stars: {user.Value.Stars}");
            sb.AppendLine($"Balance: {user.Value.Money}");
            if (user.Value.Computer != null)
            {
                sb.AppendLine($"PC Ram: {user.Value.Computer.Ram}");
                sb.AppendLine($"- {user.Value.Computer.Processor.GetType().Name} – {user.Value.Computer.Processor.Model} – {user.Value.Computer.Processor.Generation}");
                sb.AppendLine($"- {user.Value.Computer.VideoCard.GetType().Name} – {user.Value.Computer.VideoCard.Model} – {user.Value.Computer.VideoCard.Generation}");
                sb.AppendLine($"* Video card Ram: {user.Value.Computer.VideoCard.Ram}");
            }
        }
        sb.AppendLine($"System total profits: {users.Values.Sum(x => x.Money)}!!!");
        return sb.ToString().TrimEnd();
    }
}

