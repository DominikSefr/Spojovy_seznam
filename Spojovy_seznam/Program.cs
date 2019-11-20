using System;

namespace Spojovy_seznam
{
    class Program
    {
        static void Main(string[] args)
        {
            var Seznam = new MujList<string>();
            Seznam.Add("Ahoj");
            Seznam.Remove();
            Seznam.Add("Jak");
            Seznam.Add("Se");
            Seznam.Add("Máš");
            Seznam.Add(".");
            Console.WriteLine(Seznam);
        }
    }
}
