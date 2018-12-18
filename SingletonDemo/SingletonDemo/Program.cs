using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Parallel.Invoke(
                
                ()=>m1(),
                () => m2(),
                () => m3(),
                () => m4(),
                () => m5(),
                () => m6(),
                () => m7(),
                () => m8(),
                () => m9()

);

            Console.ReadKey();

        }



        private static void m8()
        {
            Singleton obj8 = Singleton.GetInstance;
        }

        private static void m9()
        {
            Singleton obj9 = Singleton.GetInstance;
        }

        private static void m7()
        {
            Singleton obj7 = Singleton.GetInstance;
        }

        private static void m6()
        {
            Singleton obj6 = Singleton.GetInstance;
        }

        private static void m5()
        {
            Singleton obj5 = Singleton.GetInstance;
        }

        private static void m4()
        {
            Singleton obj4 = Singleton.GetInstance;
        }

        private static void m3()
        {
            Singleton obj3 = Singleton.GetInstance;
        }

        private static void m2()
        {
            Singleton obj2 = Singleton.GetInstance;
        }

        private static void m1()
        {
            Singleton obj1 = Singleton.GetInstance;
        }
    }
}
