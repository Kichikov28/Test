using P13_CryptoMiningSystem;
using System;
using System.Collections.Generic;
using System.Text;
public class Computer
{
    private readonly double minedAmountPerHour;
    private int ram;
    public virtual Processor Processor { get; set; }
    public virtual VideoCard VideoCard { get; set; }

    public int Ram
    {
        get { return ram; }
        set
        {
            if (value<=0 ||value>32)
            {
                throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
            }
            ram = value;
        }
    }
    public double MinedAmountPerHour
    {
        get
        {
            return VideoCard.MinedMoneyPerHour * Processor.MineMultiplier;
        }
    }
}

