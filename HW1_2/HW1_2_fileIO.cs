using System;
using System.IO;

namespace HW1_2 {
    class HW1_2_fileIO {
        
        public string fName { get; private set; }

        HW1_2_fileIO(string fName) {
            this.fName = fName;
        }

        public string[] getAlldata() {
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
    class Actor
    {
        public string aName { get; private set; }
        public Actor(string name)
        {
            aName = name;
        }
    }

}
