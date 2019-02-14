using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fstream = File.OpenRead(@"1.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                int k = 0;
                int maxlen = 0;
                for (int i =0; i< textFromFile.Length; i++)
                {
                    if (textFromFile[i] == '1' && i != textFromFile.Length - 1)
                    {
                        k++;
                    }
                    else if (i==textFromFile.Length-1 && textFromFile[i]=='1')
                    {
                        k++;
                        if (maxlen < k)
                        {
                            maxlen = k;
                            k = 0;
                        }
                    }
                    else
                    {
                        if (maxlen < k)
                        {
                            maxlen = k;
                        }
                        k = 0;
                    }

                }
                Console.WriteLine(maxlen);
            }
            Console.ReadLine();
        }
    }
}
