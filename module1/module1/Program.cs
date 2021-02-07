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

            string[] masStringOdd = new string[masLength];
            var numberUpperOdd = 0;

            string[] masStringEven = new string[masLength];
            var numberUpperEven = 0;

            for (int i = 0, iEven = 0, iOdd = 0; i < masLength; i++)
            {
                if ((masInt[i] % 2) == 0)
                {
                    masStringEven[iEven] = Convert.ToChar(masInt[i] + 'a' - 1).ToString();
                    iEven++;
                }
                else
                {
                    masStringOdd[iOdd] = Convert.ToChar(masInt[i] + 'a' - 1).ToString();
                    iOdd++;
                }
            }

        }
    }
}
