using System;
using System.Collections.Generic;

namespace roziamoziba
{
    public class Program
    {
        static void Main()
        {
            Mozi mozi = new Mozi();
            mozi.feladat();
            mozi.musorlista.musorKiir();
            Console.ReadLine();
        }
    }
}
