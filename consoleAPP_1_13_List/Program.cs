using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAPP_1_13_List
{
    // get 2 seperate names and ages from 2 different 'sources' of UNKNOW length
    //outout them 1 line at a time...
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = getAges();
            List<string> names = getNames();
            outputNamesAndAges(names, ages);
        }

        private static void outputNamesAndAges(List<string> names, List<int> ages)
        {
            for (var i = 0; i< names.Count; i++){
                Console.WriteLine("Name:{0}, Age:{1}", names[i], ages[i]);
            }
        }

        private static List<string> getNames()
        {
            List<string> rList = new List<string>();
            rList.Add("Momo");
            rList.Add("Larry");
            rList.Add("Curly");
            rList.Add("Shemp");
            rList.Add("Oldman");
            return rList;
        }

        private static List<int> getAges()
        {
            List<int> rList = new List<int>();
            rList.Add(40);
            rList.Add(33);
            rList.Add(63);
            rList.Add(66);
            rList.Add(69);
            return rList;
        }
    }
}
