using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array1();
            Array2();
        }

        private static void Array2()
        {
            string[,] regions = new string[5, 3]
                        {
                { "İstanbul","izmit","Tekirdağ"},
                { "Trabzon","Rize","Artvin"},
                { "İzmir","Muğla","Afyon"},
                { "Diyarbakır","Mardin","Şanlıurfa"},
                { "Ankara","Sivas","Konya"}

                        };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }
        }

        private static void Array1()
        {
            string[] names = new string[3] { "Suat", "Fuat", "Umut" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
