using System;
using AljabarLibraries;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aljabar = new Aljabar();

            var akar = aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar dari x^2 - 3x - 10 = 0: " + string.Join(" dan ", akar));

            var kuadrat = aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil kuadrat dari 2x - 3: " + string.Join(", ", kuadrat));
        }
    }
}
