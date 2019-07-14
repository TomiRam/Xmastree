using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace joulukuusi
{
    class Program
    {
        static void Main(string[] args)
        {
            JouluKuusi(10);
            ReadLine();
        }
        static void JouluKuusi(int korkeus)
        {
            if (korkeus >= 3)
            {
                for (int i = 1; i < korkeus; i++)
                {
                    TulostaTyhjaa(korkeus - i);
                    TulostaTahtia(i * 2 - 1);
                }
                TulostaTyhjaa(korkeus - 2);
                TulostaTahtia(3);
                TulostaTyhjaa(korkeus - 2);
                TulostaTahtia(3);
            }
        }
        static void TulostaTyhjaa(int maara)
        {
            for (int i = 0; i < maara; i++)
            {
                Write(" ");
            }
        }
        static void TulostaTahtia(int lkm)
        {
            for (int i = 0; i < lkm; i++)
            {
                Write("*");
            }
            WriteLine();
        }
    }
}
