using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inClass_1_15_fileIO
{
    class FileIO
    {
        public string fName { get; private set; }
        FileIO(string fName)
        {
            this.fName = fName;
        }
       public string[] getAlldata()
        {
            string[] retRows = new string[0];
            try
            {
                retRows = File.ReadAllLines(this.fName);
            }
            catch
            {
                Console.WriteLine("Oh Oh File:{0} cannot open", fName);
                Environment.Exit(1);
            }
            return retRows;
        }
    }
}
