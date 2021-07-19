using System;

namespace URI_Busca_internet_exer_2413
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if (t >= 1 && t <= 1000)
            {
                t *= 2;
                t *= 2;
                Console.WriteLine(t);
            }
            
        }
    }
}
