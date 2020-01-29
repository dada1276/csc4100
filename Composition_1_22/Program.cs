using System;

namespace Composition_1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Pen", "A Red Pen");
            Product p2 = new Product(2, "Pencil", "A Number 2 Pencil");
            Product p3 = new Product(3, "Crayons", "A set of 24 colors");

            LineItem l1 = new LineItem(101, 10, p1);
            LineItem l2 = new LineItem(102, 5, p3);

            Order o1 = new Order(100, "George Jetson");
            o1.addItem(101, 10, p1);
            o1.addItem(102, 5, p3);

            showMeTheOrder(o1);
        }
    }
}
