namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return a * b / FPB(a, b);
        }

        public string Turunan(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int pangkat = persamaan.Length - 1 - i;
                int koefisien = persamaan[i] * pangkat;
                if (koefisien == 0) continue;
                string suku = koefisien + (pangkat - 1 > 0 ? $"x{(pangkat - 1 == 1 ? "" : $"^{pangkat - 1}")}" : "");
                hasil.Add(suku);
            }
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }

        public string Integral(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkat = persamaan.Length - i;
                double koefisien = (double)persamaan[i] / pangkat;
                string koefStr = koefisien == 1 ? "" : koefisien == -1 ? "-" : koefisien.ToString("0.#");
                hasil.Add($"{koefStr}x{(pangkat == 1 ? "" : $"^{pangkat}")}");
            }
            hasil.Add("C");
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }
    }
}