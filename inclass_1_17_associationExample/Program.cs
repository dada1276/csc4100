using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass_1_17_associationExample {
    class Program {
        static void Main(string[] args) {
            BankClass b = new BankClass("Chased");
            List<Employee> e = new List<Employee>();
            e.Add(new Employee("Jake"));
            e.Add(new Employee("John"));
            e.Add(new Employee("Jane"));
            e.Add(new Employee("Jessie"));
            e.Add(new Employee("Jeff"));
            showBankInfo(b, e);
        }

        private static void showBankInfo(BankClass b, List<Employee> employees) {
            Console.WriteLine("The Bank:{0}", b.bName);
            int ct = 0;
            foreach( Employee e in employees ) {
                Console.WriteLine("Employee:{0}   Name:{1}", ++ct, e.eName);
            }
        }
    }
}
