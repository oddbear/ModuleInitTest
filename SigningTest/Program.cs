using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SigningTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyPath = @"..\..\..\SignedClassLibrary\bin\Release\";

            //Bad code 1:
            //var assembly = Assembly.LoadFrom(@"..\..\..\SignedClassLibrary\bin\Release\SignedClassLibrary.dll");
            //var type = assembly.GetType("SignedClassLibrary.SomeClass");
            //var attributes = type.GetMethod("Test").GetCustomAttributes();

            //Bad code 2:
            //var obj = Activator.CreateInstance(type);

            //Bad code 3:
            //Console.WriteLine(typeof(SignedClassLibrary.SomeClass).FullName);

            var s = new Sandboxer();
            s.Main(assemblyPath);

            Console.ReadLine();
        }
    }
}
