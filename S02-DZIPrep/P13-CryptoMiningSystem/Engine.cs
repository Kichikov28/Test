using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    PCController controller;
    public Engine()
    {
        controller = new PCController();
        Run();
    }
    public void Run()
    {
        while (true)
        {
           List<string>input=Console.ReadLine().Split(", ").ToList();
            string cmd = input[0];
            switch (cmd)
            {
                case "RegisterUser":
                    Console.WriteLine(controller.RegisterUser(input));
                    break;
                case "CreateComputer":
                    Console.WriteLine(controller.CreateComputer(input));
                    break;
                case "Mine":
                    Console.WriteLine(controller.Mine());
                    break;
                case "UserInfo ":
                    Console.WriteLine(controller.UserInfo(input));
                    break;
                case "Shutdown":
                    Console.WriteLine(controller.Shutdown());
                    Environment.Exit(0);
                    break;
            }
        }

    }
}

