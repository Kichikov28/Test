using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P10_PlanetSoftware
{
    public class Star
    {
        private double distance;

        public Star(string name, double distance, int classifyStar, double weight, string starCollapse)
        {
            Name = name;
            Distance = distance;
            ClassifyStar = classifyStar;
            Weight = weight;
            StarCollapse = starCollapse;
        }

        [MaxLength(20)]
        public string Name { get; set; }
        public double Distance
        {
            get { return distance; }
            set
            {
                if (value>0)
                {
                    distance = value;
                }
            }
        }
        public int ClassifyStar { get; set; }
        public double Weight { get; set; }
        public string StarCollapse { get; set; }
        
        
    }
}
