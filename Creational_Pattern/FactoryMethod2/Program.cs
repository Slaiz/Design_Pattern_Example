using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponSelector wp = new WeaponSelector();

            Man man1 = wp.Select(Weapon.Sword);
            man1.Name = "John";
            man1.Attack();

            Man man2 = wp.Select(Weapon.Bow);
            man2.Name = "Derek";
            man2.Attack();

            Man man3 = wp.Select(Weapon.Orb);
            man3.Name = "Ponsul";
            man3.Attack();

            Console.ReadKey();
        }
    }

    public enum Weapon
    {
        Sword,
        Bow,
        Orb
    }

    abstract class Man
    { 
        public string Name{ get; set; }

        public abstract void Attack();

        public abstract void Health();
    }

    class Swordman : Man
    {
        public override void Attack()
        {
            Console.WriteLine(Name + " Attack 120 hp");
        }

        public override void Health()
        {
            Console.WriteLine("Health 550 hp");
        }
    }

    class Archer : Man
    {
        public override void Attack()
        {
            Console.WriteLine( Name + " Attack 90 hp");
        }

        public override void Health()
        {
            Console.WriteLine("Health 450 hp");
        }
    }

    class Mage : Man
    {
        public override void Attack()
        {
            Console.WriteLine(Name + " Attack 110 hp");
        }

        public override void Health()
        {
            Console.WriteLine("Health 350 hp");
        }
    }

    class WeaponSelector
    {
        public Man Select(Weapon weapon)
        {
            Man man = null;

            switch (weapon)
            {
                case Weapon.Sword:
                    man = new Swordman();
                    break;
                case Weapon.Bow:
                    man = new Archer();
                    break;
                case Weapon.Orb:
                    man = new Mage();
                    break;
                default: break;
            }

            return man;
        }

    }
}
