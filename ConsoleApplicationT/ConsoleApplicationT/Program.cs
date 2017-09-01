using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using TestClass;

//wjj_hua cl_hua1
namespace ConsoleApplicationT
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = typeof(TestClass.TestClass);

            var Methods = t.GetMethods();
            t.GetProperties();

            foreach (var item in Methods)
            {

            }

            //var method = t.GetMethod("Function1");
            var method1= t.GetMethod("Function1", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { }, null);
            var method2 = t.GetMethod("Function2");
            var method = t.GetMethod("Function2", BindingFlags.Public|BindingFlags.NonPublic | BindingFlags.Static);
            string saf = (string)method2.Invoke(null,new object[] {
                "12"
            });
            //var za = t.GetProperties()
            Console.WriteLine(saf);

            Console.ReadKey();
        }

        public static void a()
        {
            var a = typeof(TestClass.TestClass);

            var Methods = a.GetMethods();
        }
    }
}
