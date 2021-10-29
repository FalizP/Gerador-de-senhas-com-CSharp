using System;
using System.Text;

namespace GeradordeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 20, rnd;

            string pos =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" +
                "abcdefghijklmnopqrstuvwxyzç" +
                "0123456789" +
                "@#$&*";

            Random random = new Random();
            StringBuilder password = new StringBuilder();


            for (int i = 0; i < len; i++)
            {
                rnd = random.Next(0, pos.Length - 1);
                password.Append(pos[rnd]);
            }

            Console.WriteLine($"Senha gerada: {password}");
            Console.ReadKey();
        }
    }
}