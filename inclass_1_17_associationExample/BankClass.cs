using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass_1_17_associationExample {
    public class BankClass {
        public string bName { get; private set; }
        public BankClass(string name) {
            bName = name;
        }
    }
    class Employee {
        public string eName { get; private set; }
        public Employee(string name) {
            eName = name;
        }
    }
}
