using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass_1_17 {
    class Program {
        static void Main(string[] args) {
            Coin c = new Coin("Head");
            for (int i = 0; i < 10; i++) {
                c.flip();
                //c.faceValue = "On The Edge";
                Console.WriteLine("\nCoin Value={0}",c.faceValue);
            }
        }
    }
}
