using System;

namespace Week2Gloeilamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lamp mijnGloeilamp = new Lamp();
            mijnGloeilamp.TypeMateriaal = "Glas";
            mijnGloeilamp.Vermogen = 100;

            Lamp nogEenGloeilamp = new Lamp();
            nogEenGloeilamp.Vermogen = 200;

            Schakelaar mijnSchakelaar = new Schakelaar();
            mijnSchakelaar.Lampen.Add(mijnGloeilamp);
            mijnGloeilamp.Schakelaar = mijnSchakelaar;

            mijnSchakelaar.Lampen.Add(nogEenGloeilamp);
            nogEenGloeilamp.Schakelaar = mijnSchakelaar;
        }
    }
}
