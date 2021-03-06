﻿using System;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int maxlen = 0;
            using (FileStream fstream = File.OpenRead(@"1.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
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
            }
            using (FileStream fstream = new FileStream(@"OUTPUT.txt", FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(maxlen.ToString());
                fstream.Write(input, 0, input.Length);
            }
        }
    }
}
