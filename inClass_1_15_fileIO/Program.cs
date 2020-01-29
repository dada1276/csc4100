using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass_1_15_fileIO
{
    class Program
    {
        static void Main(string[] args)  {
            showSomeFileIOStuff();

            string fName = @"/Users/sunda/Desktop/AUclass/csc4100/SalesData.txt";
            string[] rows = getBooksFromFile(fName);
            outputRows(rows);

            //Hashes
            Dictionary<int, string> parts = new Dictionary<int, string>();
            parts.Add(101, "Hammer");
            parts.Add(102, "Nails");
            parts.Add(103, "ScrewDriver");
            parts.Add(104, "Saw");
            int number = 103;
            Console.WriteLine("Number:{0} is Part:{1}", number, parts[number]);
            foreach(KeyValuePair<int, string> p in parts)
            {
                Console.WriteLine("Number:{0} is Part:{1}", p.Key, p.Value);
            }

        }
        
        private static void outputRows(string[] rows) {
            foreach(String row in rows)   {
                string[] toks = row.Split(';');
                Console.WriteLine("Title:{0} Author:{1} Sold:{2}",
                    toks[0], toks[1], toks[2]);
            }
        }

        private static string[] getBooksFromFile(string fName)  {
            string[] retRows = new string[0];
            try {
                retRows = File.ReadAllLines(fName);
            } catch {
                Console.WriteLine("Oh Oh File:{0} cannot open", fName);
                Environment.Exit(1);
            }
            
            return retRows;
        }

        private static void showSomeFileIOStuff() {
            DirectoryInfo currDir = new DirectoryInfo(",");
            Console.WriteLine("Current Dir={0}", currDir.FullName);
            Console.WriteLine("Partent Dir={0} attr:{1} createTime={2}",
                currDir.Parent, currDir.Attributes, currDir.CreationTime);
            DirectoryInfo sd = new DirectoryInfo("/Users/sunda/Desktop/AUclass/csc4100/SalesData.txt");
            Console.WriteLine("Current Dir={0}", sd.FullName);
            Console.WriteLine("Partent Dir={0} attr:{1} createTime={2}",
                sd.Parent, sd.Attributes, sd.CreationTime);
        }
    }
}
