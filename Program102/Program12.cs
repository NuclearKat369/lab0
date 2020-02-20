using System;

namespace Program12
{
    class Program12
    {
        static void Main(string[] args)
        {
            
            double y = trig.Pi / 4;                     

            Console.WriteLine("Значение угла равно " + y + "\nКосинус равен " + trig.cosx(y));            

            Console.WriteLine("Гиперболический синус равен " + trig.shx(y));

            Console.WriteLine("Гиперболический косинус равен " + trig.chx(y));

            Console.ReadLine();
        }
    }

    public class trig
    {
        public const double Pi = 3.141592;
        static int n = 100;
        public static double cosx(double a)
        {
            double cos = 0, q = a;
            for (int i = 0; q <= n; i++)
            {
                cos += q;
                q*= ((-1) * a * a) / ((2 * i + 1) * (2 * i + 2));
            }
            
            return cos;

        }

        public static double shx(double a)
        {
            double sh = 0, q = a;
            for (int i = 0; q <= n; i++)
            {
                sh += q;
                q *= (a * a) / ((2 * i + 2) * (2 * i + 3));
            }

            return sh;

        }
        
        public static double chx(double a)
        {
            double ch = 0, q = a;
            for (int i = 0; q <= n; i++)
            {
                ch += q;
                q *= (a * a) / ((2 * i + 1) * (2 * i + 2));
            }
            return ch;            
        }
    }
}
