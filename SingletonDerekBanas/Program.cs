using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDerekBanas
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton newInstance = Singleton.getInstance();
            Console.WriteLine("Instance ID:" + newInstance.ToString());
            Console.WriteLine("Player 1");
            Console.WriteLine(string.Join(",", newInstance.GetLettersList()));
            Console.WriteLine(string.Join(",", newInstance.GetTiles(7)));
            Console.WriteLine("Player 2");
            Console.WriteLine(string.Join(",", newInstance.GetLettersList()));
            Console.WriteLine(string.Join(",", newInstance.GetTiles(7)));
            

            Console.ReadLine();
        }
    }
}
