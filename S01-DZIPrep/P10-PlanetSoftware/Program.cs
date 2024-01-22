using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_PlanetSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Star star1 = new Star("Proxima Centauri", 4.24, 8, 0.122, "Centaurus");

            Star star2 = new Star("Alpha Centauri", 4.36, 6, 1.1, "Centaurus");

            Star star3 = new Star("Betelgeuse", 427, 3, 20, "Orion");
            List<Star> stars = new List<Star>();
            stars.Add(star1);
            stars.Add(star2);
            stars.Add(star3);
            GetByAverage(stars);
            //DisplayStars(GetStartByDistance(stars));

        }
        public static void GetByAverage(List<Star> stars)
        {
            var constellations = stars.GroupBy(x => x.StarCollapse);
            foreach (var constellation in constellations)
            {
                double averageMass = constellation.Average(x => x.Weight);
                Console.WriteLine($"{constellation.Key}, Average Mass: {averageMass:f2} solar masses");
            }
        }
        public static List<string> GetStarsByConstellation(List<Star> stars)
        {
            List<string> list = new List<string>();
            foreach (Star star in stars.OrderBy(x => x.StarCollapse).ThenByDescending(x => x.Weight))
            {
                string text = PrintStars(star);
                list.Add(text);
            }
            return list;

        }

        public static List<Star> GetStartByDistance(List<Star> stars)
        {
            return stars.OrderBy(x => x.Distance).ToList();
        }
        public static void DisplayStars(List<Star> stars)
        {
            foreach (var star in stars)
            {
                string text = PrintStars(star);
                Console.WriteLine(text);
            }
        }
        private static string PrintStars(Star star)
        {
            return $"{star.Name}, {star.Distance} light years, {StarType(star.ClassifyStar)}, {star.Weight} light mass, {star.StarCollapse}";
        }
        public static string StarType(int n)
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                 {1, "Хипергигант"},
                 {2, "Свръхгигант"},
                 {3, "Ярък Гигант"},
                 {4, "Гигант"},
                 {5, "Субгигант"},
                 {6, "Джудже"},
                 {7, "Субджудже"},
                 {8, "Червено Джудже"},
                 {9, "Кафяво Джудже"}
            };
            return names[n];
        }
    }
}
