using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
   public sealed class Singleton
    {
        private static int count;
        private static Singleton Instance = null;   // lazy noraml

       // private static readonly Singleton Instance = new Singleton();  // eager 
        private static readonly object obj = new object();

       // private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(); // lazy external

        
            // lazy normal code

        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null || count<5)
                {
                    lock (obj)
                    {

                         if(Instance == null || count<5)
                        {
                            Instance = new Singleton();
                        }

                    }
                }
               
                return Instance;
            }
        }

    

        // Eager loading code

/*
        public static Singleton GetInstance
        {
            get
            {
               
                return Instance;
            }
        }

    */



            //Lazy loading external code

            /*
        public static Singleton GetInstance
        {
            get
            {

                return Instance.Value;
            }
        }

    */

        private Singleton()
        {
            ++count;
            Console.WriteLine("count is  " + count); 
            
        }
    }
}
