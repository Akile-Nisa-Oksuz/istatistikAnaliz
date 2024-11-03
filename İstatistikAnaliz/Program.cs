using System;
using System.Linq;
using MathNet.Numerics.Statistics;

namespace IstatistikAnaliz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan veri al  
            Console.WriteLine("Veri kümesini (n sayıda sayı) girin, virgül ile ayırın:");
            string input = Console.ReadLine();
            double[] data = input.Split(',')
                                 .Select(double.Parse)
                                 .ToArray();

            // İstatistiksel hesaplamalar  
            double average = Statistics.Mean(data);
            double median = Statistics.Median(data);
            double variance = Statistics.Variance(data);
            double standardDeviation = Statistics.StandardDeviation(data);

            // Sonuçları yazdır  
            Console.WriteLine($"Ortalama: {average}");
            Console.WriteLine($"Medyan: {median}");
            Console.WriteLine($"Varyans: {variance}");
            Console.WriteLine($"Standart Sapma: {standardDeviation}");
        }
    }
}