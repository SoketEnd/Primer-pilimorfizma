using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Car
    {

        protected virtual void Start()
        {
            Console.WriteLine("BRBRBRBR");
        }
        public virtual void Drive()
        {
            Start();
            Console.WriteLine("Я еду на маленькой машине");
        }
    }

    class hammer : Car
    {
        public override void Drive()
        {
            Start();
            Console.WriteLine("Теперь я еду на большой машшине !");
        }
    }

    class Human
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.Drive(new hammer());
        }
    }
}
