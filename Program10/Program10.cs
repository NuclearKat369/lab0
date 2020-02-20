using System;

namespace Program10
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("Введите желаемое количество символов: ");
            string nums = Console.ReadLine();
            int n = Int32.Parse(nums);

            Random rand = new Random();
            int r;
                                    
            char[] symb = new char[n];
            for (int i = 0; i < symb.Length; i++)
            {
                r = rand.Next(26);
                symb[i] = (char) ('a' + r);
            }
            
            Console.WriteLine(getTxt(text, symb));

            static string getTxt(string t, params char[] sym)
            {

                string c = new string(sym);
                string txt = t + "[-]" + c;

                return txt;
            }
            Console.ReadLine();
        }
    }
}
