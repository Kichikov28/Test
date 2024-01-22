using System;

namespace P02_WordsGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word;
            double maxPoints=double.MinValue;
            string winWord = string.Empty;
            while (true)
            {
                word=Console.ReadLine();
                if (word=="END OF GAME")
                {
                    break;
                }

                double points = 0;

                foreach (char letter in word)
                {
                    points += (double)letter;
                }

                if (word.Length >= 10)
                {
                    points += 30;
                }
                if (word.Length - 1 == 't')
                {
                    points += 20;
                }
                if (word[0] >= 'A' && word[0]<='Z')
                {
                    points += 15;
                }
                if (points>maxPoints)
                {
                    maxPoints = points;
                    winWord= word;
                }

            }
            Console.WriteLine(winWord);
            Console.WriteLine(maxPoints);

        }
    }
}
