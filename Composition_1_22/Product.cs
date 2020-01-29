using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_1_22 {
    class Product {
        public int id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }

        public Product(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        { 
            StringBuilder sb = new StringBuilder("ID: " + id);
            sb.Append("Name: " + name);
            sb.Append("Descript: " + description);
            return sb.ToString();
        }
    }

    class LineItem
    {
        public int id { get; private set; }
        public int quantity { get; private set; }
        public Product p { get; private set; }
        public LineItem(int id, int q, Product p)
        {
            this.id = id;
            this.quantity = q;
            this.p = p;
        }
    }
    class Order
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public List<LineItem> itemList;
        public Order(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void addItem(int id, int quantity, Product p)
        {
            this.itemList.Add(new LineItem(id, quantity, p));
        }
    }
}
