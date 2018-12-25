using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.hello_world
{
    public class HelloWorld
    {
        public static string Hello(string name) =>
            string.IsNullOrWhiteSpace(name)
                ? "Hello, World!"
                : $"Hello, {name}!";
    }
}