using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Program13new
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\1392659\Desktop\prog13\Sample scores.txt";
            string path2 = @"C:\Users\1392659\Desktop\prog13\Sample students.txt";
            Console.WriteLine("Enter ID number:");
            Console.WriteLine("(20180001,20180002,20180003)");
            string find = Console.ReadLine();
            int i = 0;
            int j = 0;
            string Java = "ERROR";
            string CSharp = "ERROR";
            string name = "ERROR";
            using (StreamReader sr = new StreamReader(path1))
            {
                while (j != 1)
                {
                    CSharp = sr.ReadLine();
                    if (CSharp.Contains(find))
                    {
                        j++;
                    }
                }
                j = 0;
                while (j != 1)
                {
                    Java = sr.ReadLine();
                    if (Java.Contains(find))
                    {
                        j++;
                    }
                }
            }
            using (StreamReader sr = new StreamReader(path2))
            {
                while (i != 1)
                {
                    name = sr.ReadLine();
                    if (name.Contains(find))
                    {
                        i++;
                    }
                }
            }
            CSharp = CSharp.Remove(0,11);
            Java = Java.Remove(0, 11);
            name = name.Replace(" | ", " ").Replace(find, "");
            using (StreamWriter sw = new StreamWriter(path1.Replace("Sample scores.txt", ((Convert.ToString(find) + ".txt")))))
            {
                int average = (Convert.ToInt32(CSharp) + Convert.ToInt32(Java)) / 2;
                sw.WriteLine(name + " - average score " + average);
                sw.WriteLine("C# " + CSharp);
                sw.WriteLine("Java " + Java);
            }
        }
    }
}
