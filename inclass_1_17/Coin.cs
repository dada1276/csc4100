using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inclass_1_17 {

    public class Coin {

        public  String faceValue { get; private set; }
        public string coinColor { get; private set; }
        public string coinType {
            get { return this.coinType; }
            set {
                if (value.Equals("N") || value.Equals("D") || value.Equals("Q")) {
                    coinType = value;
                    coinColor = "Sliver";
                } else {
                    Console.WriteLine("Illegal coinType detected:{0}", value);
                }
            }
        }

        public Coin(string fv) {
            faceValue = fv;
        }

        public void flip() {
            Random rnd = new Random();
            int rNum = rnd.Next(1, 3);
            if (rNum == 1) {
                faceValue = "Head";
            } else if (rNum == 2){
                faceValue = "Tails";
            } else {
                //this is an example of defenisve programming
                Console.WriteLine("That flip not possible:{0}", rNum);
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("fv:" + faceValue);
            return base.ToString();
        }
    }
}
