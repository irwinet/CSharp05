using System;

namespace CSharp05.Model
{
    public class Students
    {
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Password { get; set; }

        public string getFullName(){
            return $"{Name} {Surnames}";
        }
    }
}
