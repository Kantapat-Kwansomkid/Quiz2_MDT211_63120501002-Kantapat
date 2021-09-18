using System;

namespace Quiz2_MDT211_63120501002-Kantapat
{
    class ID
    {
        private int totalID = 0;

        public void Write(int ID)
        {
            this.totalID = this.totalID + ID;
        }

        public int GetTotalTree()
        {
            return this.totalID;
        }

    }

    class Tree : ID
    {
        private string Tree_name;

        public void LoadTree_name(string Tree_name)
        {
            this.Tree_name = Tree_name;
        }

        public string GetTree_name()
        {
            return this.Tree_name;
        }
    }
    class Flower : ID { }

    class Program
    {
        static void Main(string[] args)
        {
            PrintTreeInformation();
            PrintPickupInformation();
        }

        static void PrintTreeInformation()
        {
            Tree tree = new Tree();
            tree.LoadTree_name("ID: 1");
            tree.Write(80);
            tree.Write(40);

            Console.WriteLine("Input Rose");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("ID: 1");
            Console.WriteLine("Plant name: ดอกกุหลาบสีขาว");
            Console.WriteLine("Plant description: สวยงามมาก", tree.GetTotalTree());
            Console.WriteLine("Amount: 2", tree.GetTree_name());
        }

        static void PrintPickupInformation()
        {
            Flower flower = new Flower();
            flower.Write(120);
            flower.Write(70);

            Console.WriteLine("Height: 10.5");
            Console.WriteLine("Circumference: 6", flower.GetTotalTree());
        }
    }
}
