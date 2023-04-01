using System;

namespace Pz_5_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var harly = new Sotrudnik("Harly", 34, Otdel_name.Otdel_Kadrov);

            Console.WriteLine(harly.ToString());

            var bob = harly;
            bob.Name = "Bob";

            Console.WriteLine(harly.ToString());



            var bella = new Sotrudnik("Bella", 23, Otdel_name.Otdel_Prodazh);
            var klint = (Sotrudnik)bella.Clone();

            klint.Name = "Klint";

            Console.WriteLine(bella.ToString());
            Console.WriteLine(klint.ToString());
        }
    }
}
