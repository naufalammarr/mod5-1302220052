using System.Numerics;

namespace modul5_1302220052
{
    class Program
    {

        public class Penjumlahan
        {
            public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : IAdditionOperators<T, T, T>
            {


                return angka1 + angka2 + angka3;
            }
            private static void Main(string[] args)
            {
                //1302220052

                Console.WriteLine("Hasil Penjumlahan adalah 37", JumlahTigaAngka<float>(13, 02, 22));
            }
        }


    }
}