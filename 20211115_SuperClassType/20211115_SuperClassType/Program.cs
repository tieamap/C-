using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211115_SuperClassType
{
    class Customer
    {
        public string name;
        public void registry(string name)
        {
            this.name = name;
        }
    }

    class Country : Customer
    {
        string country;
        void registry(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Country();
            obj.registry("Gerry Lopez");
            Console.WriteLine(obj.name);
        }
    }
}
