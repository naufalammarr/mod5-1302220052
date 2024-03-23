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

                SimpleDataBase<float> data = new SimpleDataBase<float>();
                data.AddNewData(13);
                data.AddNewData(02);    
                data.AddNewData(22);
                data.printAllData();
            }
        }
    
    public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase() 
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }

            public void AddNewData(T data) 
            {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }

            public void printAllData() 
            {
                for (int i = 0; i < storedData.Count; i++) 
                {
                    Console.Write(storedData[i]);
                    Console.WriteLine(inputDates[i]);
                }
                
            }
        }

    }
}