using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_MD.Console
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User() 
        {
          Name = "Mahammad";
            Age = 21;
        }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Greet()
        {
            System.Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
        public string Greetwithreturn()
        {
            string result = $"Hello, my name is {Name} and I am {Age} years old.";
            return result;
        }
        public string Greetwithreturn(string name, int age)
        {
            string result = $"Hello, my name is {name} and I am {age} years old.";
            return result;
        }

    }
}
