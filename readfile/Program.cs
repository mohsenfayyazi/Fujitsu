using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
           
            if (args.Length == 0)
            {
                Console.WriteLine("Invalid args");
                return;
            }

            GetList(args[0]);
            //GetList(@"C:\Users\Mohsen\Desktop\ACME");
            Console.WriteLine("Press any key");
            Console.Read();
        }
        static void GetList(string dir)
        {
            string[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            Array.Sort(files, StringComparer.Ordinal);
            List<string> UniqFile = new List<string>();
            foreach (string file in files)
            {
                
                UniqFile.Add(Path.GetFileName(file.ToLower()));
            }
            UniqFile.Sort();
            foreach (string uniqfile in UniqFile.Distinct())
            {
                Console.WriteLine(Path.GetFileName(uniqfile.ToLower()));
                
            }
        }
    }
}
