using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedClassLibrary
{
    public class SomeClass
    {
        [Test(Name = "test")]
        public void Test(bool something)
        {
            if (something)
                Console.WriteLine("A");
            else
                Console.WriteLine("B");
        }
    }

    public class TestAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
