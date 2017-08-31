using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDerekBanas
{
    /// <summary>
    /// 
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// Static Object : Always you wants to use one and only one instance
        /// </summary>
        private static Singleton firstInstance = null;

         String[] scrabbleLetters = 
             {  "a", "a", "a", "a", "a", "a", "a", "a", "a",
                "b", "b", "c", "c", "d", "d", "d", "d", "e", "e", "e", "e", "e",
                "e", "e", "e", "e", "e", "e", "e", "f", "f", "g", "g", "g", "h",
                "h", "i", "i", "i", "i", "i", "i", "i", "i", "i", "j", "k", "l",
                "l", "l", "l", "m", "m", "n", "n", "n", "n", "n", "n", "o", "o",
                "o", "o", "o", "o", "o", "o", "p", "p", "q", "r", "r", "r", "r",
                "r", "r", "s", "s", "s", "s", "t", "t", "t", "t", "t", "t", "u",
                "u", "u", "u", "v", "v", "w", "w", "x", "y", "y", "z",};
        /// <summary>
        /// Letter List
        /// </summary>
         private LinkedList<string> letterList = null;

         private static bool firstThread = true;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private Singleton() {
            letterList = new LinkedList<string>(scrabbleLetters.OrderBy(a=> Guid.NewGuid() ).ToList());
            
        }

        /// <summary>
        /// Lazy Instantiation
        /// Not Thread Safe
        /// </summary>
        /// <returns></returns>
        public static Singleton getInstance()
        {
            if(firstInstance == null)
            {
                if (firstThread)
                {
                    firstThread = false;
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    
                }

                firstInstance = new Singleton();
            }
            return firstInstance;
        }

        /// <summary>
        /// Lazy Instantiation
        /// Thread Safe
        /// </summary>
        /// <returns></returns>
        public static Singleton getInstanceThreadSafe()
        {
            if (firstInstance == null)
            {
                firstInstance = new Singleton();
                
            }
            return firstInstance;
        }

        public LinkedList<string> GetLettersList()
        {
            return firstInstance.letterList;
        }

        public LinkedList<string> GetTiles(int howmanyTiles)
        {
            var retList = new LinkedList<string>(firstInstance.letterList.Take(howmanyTiles));
            foreach(var item in retList)
            {
                firstInstance.letterList.Remove(item);
            }
            return retList;

        }
    }
}
