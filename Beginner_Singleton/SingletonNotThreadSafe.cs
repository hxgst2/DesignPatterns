using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Singleton
{
    public class SingletonNotThreadSafe
    {
        // Singleton characteristic 1>> Variable is static
        private static SingletonNotThreadSafe instance = null;
        // Singleton characteristic 1>> Constroctor is Private & it's parameterless
        private SingletonNotThreadSafe()
        {

        }
        public static SingletonNotThreadSafe Instance
        {
            get 
            {
                //if (instance == null) 
                //{
                //    instance = new SingletonNotThreadSafe(); 
                //}
                //return instance;
                // OR
                return instance ?? (instance = new SingletonNotThreadSafe());
            }
        }
    }
}
