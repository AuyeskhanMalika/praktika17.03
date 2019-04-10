using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(List<>);
            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine("Конструкторы List<>: ");
            foreach (var construct in constructors)
            {
                Console.WriteLine(construct.ToString());
            }
            Console.Read();
        }
    }
    }
}
