using System;

namespace CharacterNotPresentOptimized
{
    class Program
    { 
        void findAndPrintUncommonChars(string str1, string str2)
        {
            int MAX_CHAR = 26;
             
            int [] present=new int[MAX_CHAR];
            for (int i = 0; i < MAX_CHAR; i++)
                present[i] = 0;

            int l1 = str1.Length;
            int l2 = str2.Length;

            
            for (int i = 0; i < l1; i++)
                present[str1[i] - 'A'] = 1;

     
            for (int i = 0; i < l2; i++)
            {
               
                if (present[str2[i] - 'A'] == 1
                    || present[str2[i] - 'A'] == -1)
                    present[str2[i] - 'A'] = -1;
                
                else
                    present[str2[i] - 'A'] = 2;
            }


            Console.Write("Op1 : ");
            for (int i = 0; i < MAX_CHAR; i++)
            {
                if (present[i] == 1)
                {
                    Console.Write((char)(i + 'A'));
                }
            }

            Console.WriteLine();

            Console.Write("Op2 : ");
            for (int i = 0; i < MAX_CHAR; i++)
            {
                if (present[i] == 2)
                {
                    Console.Write((char)(i + 'A'));
                }
            }

            Console.ReadKey();


        }






        static void Main(string[] args)
        {
            string input1, input2;
            Console.WriteLine("Enter the input1");
            input1 = Console.ReadLine();

            Console.WriteLine("Enter the input2");
            input2 = Console.ReadLine();

            Program p = new Program();
            p.findAndPrintUncommonChars(input1,input2);

        }



    }
}
