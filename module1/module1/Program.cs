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

            CountingUpper(masStringEven, out numberUpperEven);
            CountingUpper(masStringOdd, out numberUpperOdd);

            char compareSign = numberUpperEven > numberUpperOdd ? '>' : (numberUpperEven == numberUpperOdd ? '=' : '<');

            Console.WriteLine($"numberUpperEven {compareSign} numberUpperOdd");

            PrintMas(masStringEven);
            PrintMas(masStringOdd);

            void CountingUpper(string[] mas, out int numberUpper)
            {
                numberUpper = 0;

                string[] letterUpper = { "a", "e", "i", "d", "h", "j" };

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < letterUpper.Length; j++)
                    {
                        if (mas[i] == letterUpper[j])
                        {
                            mas[i] = mas[i].ToUpper();
                            numberUpper++;
                        }
                    }
                }
            }

            void PrintMas(string[] mas)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + ' ');
                }

                Console.WriteLine();
            }
        }
    }
}
