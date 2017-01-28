using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();

            Console.ReadLine();
        }
    }
    abstract class Weapon
    {
        public abstract void Hit();
    }
    abstract class Movement
    {
        public abstract void Move();
    }

    class Bow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine(" Bow shot ");
        }
    }
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine(" Sword hit ");
        }
    }
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine(" Fly ");
        }
    }
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine(" Run ");
        }
    }
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Bow();
        }
    }
    class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
    class Hero
    {
        private Weapon weapon;
        private Movement movement;
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
