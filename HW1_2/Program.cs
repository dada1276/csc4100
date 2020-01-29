using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            string fName = @"/Users/sunda/Desktop/AUclass/csc4100/BestActors.txt";
            string[] rows = getActorsFromFile(fName);
            List<Actor> actors = new paresIntoObject(rows);
            string inActor = getActorFromUser();
            if (inActor.ToLower().Equals("stop")) {
                keepGoing = false;
            } else {
                showThisActor(inActor, actors);
            }
        }
        private static string getActorFromUser()
        {
            Console.WriteLine("What actor are you interested in?->");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            return name;
        }


        class paresIntoObject : List<Actor>
        {
            private string[] rows;

            public paresIntoObject(string[] rows)
            {
                foreach (String row in rows)
                {
                    string[] toks = row.Split(';');
                    Console.WriteLine("Title:{0} Author:{1} Sold:{2}",
                        toks[0], toks[1], toks[2]);
                }
            }
        }

        private static void showThisActor(string inActor, List<Actor> actors)
        {
            DirectoryInfo currDir = new DirectoryInfo(",");
            DirectoryInfo sd = new DirectoryInfo("/Users/sunda/Desktop/AUclass/csc4100/BestActors.txt");
            Console.WriteLine("Current Dir={0}", sd.FullName);
            Console.WriteLine("Partent Dir={0} attr:{1} createTime={2}",
                sd.Parent, sd.Attributes, sd.CreationTime);
        }

        

        private static string[] getActorsFromFile(string fName) {
            string[] retRows = new string[0];
            try
            {
                retRows = File.ReadAllLines(fName);
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
