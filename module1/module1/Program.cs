using System;

namespace Module1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var masLength = int.Parse(Console.ReadLine());

            int[] masInt = new int[masLength];

            for (int i = 0; i < masLength; i++)
            {
                masInt[i] = new Random().Next(1, 27);
            }
        }
    }
}
