using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // stop watch object 
            Stopwatch sw = new Stopwatch();

            // read input keys from text file.
            StreamReader sr1 = new StreamReader("C:\\Users\\Edmond\\Desktop\\key.txt");
            //read input value from textfile .
            StreamReader sr = new StreamReader("C:\\Users\\Edmond\\Desktop\\value.txt");
            HashTable table = new HashTable();
            const int SIZE=6758;
            string[] value = new string[SIZE];
            string[] Tempkey = new string[SIZE];
            int[] key = new int[SIZE];
            Tempkey[0] = sr1.ReadLine();
            key[0] = Convert.ToInt32(Tempkey[0]);
            value[0]=sr.ReadLine();
            table.put(key[0], value[0]);
            for (int i = 1; i < SIZE; i++)
            {
                Tempkey[i]=sr1.ReadLine();
                key[i]=Convert.ToInt32(Tempkey[i]);
                value[i] = sr.ReadLine();
                table.put(key[i],value[i]);
            }
            
            // create a hashtable pointer named table 
            // that point to a block of memoery .
            //HashTable table = new HashTable();
            //table.LinearProbing(4, "john");
            //table.put(60, "Eddie");
            //table.put(5, "Edmond");
            //table.put(20, "Bettice");
            //table.put(50, "Betty");
           
            Console.WriteLine(table.get(6217));
            
            Console.WriteLine(table.get(102155));
            
            Console.WriteLine(table.get(270427));
            //sw.Start();
            Console.WriteLine(table.get(313469));
            //sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(140003));
            //sw.Stop();
            sw.Start();
            Console.WriteLine(table.get(840620));
            sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(2007748));
            //sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(2016245));
            //sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(2288));
            //sw.Stop();
            ///sw.Start();
            Console.WriteLine(table.get(61537));
           // sw.Stop();
           // sw.Start();
            Console.WriteLine(table.get(50340));
            //sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(12011063));
           // sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(20337070));
            //sw.Stop();
            //sw.Start();
            Console.WriteLine(table.get(40223070));
            var time = sw.ElapsedMilliseconds;
            Console.WriteLine(time);
            
            
            
            Console.ReadLine(); 
        }
    }
}
