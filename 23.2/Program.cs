using System;

namespace _23._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Strochka s1 = new Strochka("Николай");
            Strochka s2 = new Strochka("Синяк");
            Strochka s3, s4, s5, s6 = new Strochka();

            s3 = s1 + s2;
            Console.Write(s3.getStr());
            s4 = s1 - s2;
            Console.Write(s4.getStr());
            s5 = s1 * s2;
            Console.Write(s5.getStr());

            Strochka s7 = new Strochka(s5);
            Console.Write(" // = Конструктор копирования ->  " + s7.getStr());

            s6 = s1 / s2;
            Console.Write(s6.getStr());

            Console.ReadKey();
        }
    }

    internal class Strochka
    {
        private string str;

        public Strochka()
        {
        }

        public Strochka(string str)
        {
            this.str = str;
        }

        public static Strochka operator +(Strochka s1, Strochka s2)
        {
            Console.Write("Перегрузка (a+b) -> ");
            string str = s1.str + " " + s2.str;
            return new Strochka(str);
        }

        public static Strochka operator -(Strochka str1, Strochka str2)
        {
            Console.Write("\nПерегрузка (a-b) -> ");
            string s1 = str2.str;
            string s2 = str1.str;
            string str = s1 + " " + s2;
            return new Strochka(str);
        }

        public static Strochka operator *(Strochka str1, Strochka str2)
        {
            Console.Write("\nПерегрузка (a*b) -> ");
            string str = str1.str;
            for (int i = 0; i < str2.str.Length; i++)
            {
                str = str.Replace(str2.str[i], ' ');
            }
            str = str.Replace(" ", "");
            return new Strochka(str);
        }

        public static Strochka operator /(Strochka str1, Strochka str2)
        {
            Console.Write("\nПерегрузка (a/b) -> ");
            int t;
            string str = "";
            int si1 = str1.str.Length;

            for (int i = 0; i < si1; i++)
            {
                if (i < str1.str.Length)
                {
                    // str = str + str1.str[i];
                    Console.Write(str1.str[i]);
                }
                if (str1.str.Length > str2.str.Length)
                {
                    t = str1.str.Length - str2.str.Length;
                }
                else
                {
                    t = str2.str.Length - str1.str.Length;
                    si1 = si1 + t;
                }

                for (int j = 0; j < str2.str.Length; j++)
                {
                    if (j == i)
                    {
                        // str = str + "<"+str2.str[j]+">";
                        Console.Write("<" + str2.str[j] + ">");
                    }
                }
            }

            return new Strochka(str);
        }

        public string getStr()
        {
            return this.str;
        }

        ~Strochka()
        {
        }

        public Strochka(Strochka copy)
        {
            str = copy.str;
        }
    }
}