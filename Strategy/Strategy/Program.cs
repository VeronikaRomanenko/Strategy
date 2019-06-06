using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Person person = new Person() { person = new Man() { Name = "Мужчина" } };
            person.Algorithm(rnd);
            person.person = new Woman() { Name = "Женщина" };
            person.Algorithm(rnd);
            person.person = new Child() { Name = "Ребенок" };
            person.Algorithm(rnd);
        }
    }
    class Person
    {
        public IPerson person { set; get; }
        public int Algorithm(Random rnd)
        {
            return person.Algorithm(rnd);
        }
    }
    interface IPerson
    {
        string Name { set; get; }
        int Algorithm(Random rnd);
    }
    class Man : IPerson
    {
        public string Name { set; get; }

        public int Algorithm(Random rnd)
        {
            int res = 0;
            if (rnd.Next(10) > 4)
            {
                res += 100;
                Console.Write($"{Name} попал в мишень");
                int tmp = rnd.Next(30);
                res -= (tmp * 5);
                if (res < 0) res = 0;
                Console.WriteLine($" за {tmp} секунд и получил {res} баллов");
            }
            else
            {
                Console.WriteLine($"{Name} не попал в мишень");
            }
            return res;
        }
    }
    class Woman : IPerson
    {
        public string Name { set; get; }
        public int Algorithm(Random rnd)
        {
            int res = 0;
            if (rnd.Next(10) > 5)
            {
                res += 100;
                Console.Write($"{Name} попала в мишень");
                int tmp = rnd.Next(40);
                res -= (tmp * 4);
                if (res < 0) res = 0;
                Console.WriteLine($" за {tmp} секунд и получила {res} баллов");
            }
            else
            {
                Console.WriteLine($"{Name} не попала в мишень");
            }
            return res;
        }
    }
    class Child : IPerson
    {
        public string Name { set; get; }
        public int Algorithm(Random rnd)
        {
            int res = 0;
            if (rnd.Next(10) > 6)
            {
                res += 200;
                Console.Write($"{Name} попал в мишень");
                int tmp = rnd.Next(150);
                res -= (tmp * 2);
                if (res < 0) res = 0;
                Console.WriteLine($" за {tmp} секунд и получил {res} баллов");
            }
            else
            {
                Console.WriteLine($"{Name} не попал в мишень");
            }
            return res;
        }
    }
}