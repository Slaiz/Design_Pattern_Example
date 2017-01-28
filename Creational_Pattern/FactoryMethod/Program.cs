using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("Panel dev");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Wood dev");
            House house = dev.Create();

            Console.ReadLine();
        }
    }

    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        abstract public House Create();
    }
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    { }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel home build");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood home build");
        }
    }
}
