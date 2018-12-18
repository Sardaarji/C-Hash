using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {

            string[] res = new string[20];
           
            try
            {
                Console.WriteLine("enter the file details");
                using (StreamWriter sw = new StreamWriter("D:/names.txt",append:true))
                {
                    String name;

                    // enter " exit " to stop
                    
                    while ((name = (Console.ReadLine())) != "exit")
                        sw.WriteLine(name);
                }

                using (StreamReader sr = new StreamReader("D:/names.txt"))
                {
                    String line;

                    Console.WriteLine("the contents of the file are");
                    while ((line = sr.ReadLine()) != null)
                    {
                        string temp = "", temp1 = "";
                        bool bol = true;
                        Console.WriteLine(line);
                        string[] arr = line.Split(",");

                        temp += (arr[0] + arr[1]);
                        temp1 += (arr[1] + arr[0]);



                        foreach (string cmp in res)
                        {
                            if (temp == cmp || temp1 == cmp)
                            {
                                bol = false;
                                break;
                            }
                        }


                        using (StreamWriter sw = new StreamWriter("D:/namesR.txt", append: true))
                        {
                            if (bol)
                            {
                                res[count++] = temp;
                                sw.WriteLine(line);
                            }
                        }

                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine("there was problem in reading from the file");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
