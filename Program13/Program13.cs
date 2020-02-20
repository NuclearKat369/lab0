using System;

namespace Program13
{
    class Program13
    {
        static void Main(string[] args)
        {
            string x = "Международное право - это система принципов и норм, которая регулирует отношения" +
                " между субъектами международного права.";

            char y = 'е';

            Texto txt = new Texto(x, y);

            Console.WriteLine(txt.ToString());

            Console.ReadLine();
        }
    }

    public class Texto
    {
        string line;
        char ch;

        public Texto(string t, char c)
        {
            ch = c;
            line = t;
        }

        public string[] getTxt()
        {
            string[] symb;
            symb = line.Split(ch);
            return symb;
        }

        public override string ToString()
        {
            string str = "Текст: " + line + "\nРазделитель: " + ch
                + "\nЗначения подстрок: \n" + string.Join("\n", getTxt());
            return str;
        }
    }
}



