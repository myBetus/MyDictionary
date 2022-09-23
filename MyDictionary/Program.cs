using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> kelimeler = new MyDictionary<string, string>();
            kelimeler.Add("portakal", "domates");
            kelimeler.Add("mandalina", "salatalık");
            kelimeler.Add("çilek", "brokoli");
            kelimeler.Add("muz", "kabak");
            kelimeler.Add("avakado", "maydanoz");
            kelimeler.List();
            Console.ReadKey();
        }
        
    }
}
