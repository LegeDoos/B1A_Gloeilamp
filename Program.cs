using System;

namespace Week2Gloeilamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string mijnNaam;
            mijnNaam = "Rob";
            Console.WriteLine(mijnNaam);

            Lamp mijnGloeilamp = new Lamp();
            mijnGloeilamp.TypeMateriaal = "Glas";
            mijnGloeilamp.Vermogen = 100;

            Lamp nogEenGloeilamp = new Lamp();
            nogEenGloeilamp.Vermogen = 200;
        }
    }
}
