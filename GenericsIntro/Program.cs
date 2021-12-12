using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Engin");
            isimler.Add("Durmuş");
            isimler.Add("Turabi");
            isimler.Add("Ali");

            Console.WriteLine("merhaba programcı");





        }
    }
}
