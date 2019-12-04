using System;

namespace Spojovy_seznam
{
    class Program
    {
        static void Main(string[] args)
        {
            var Seznam = new MujList<string>();
            Seznam.Add("1");
            Seznam.Remove();
            Seznam.Add("2");
            Seznam.Add("3");
            Seznam.Add("4");
            Seznam.Add("5");
            Seznam.Insert("insert", 2);
            Seznam.RemoveAt(2);
            
            Console.WriteLine(Seznam);
        }
    }
}
