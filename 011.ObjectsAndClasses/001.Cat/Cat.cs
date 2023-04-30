using System;
using System.Collections.Generic;
using System.Text;

namespace _001.Cat
{
    public class Cat
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Cat()
        {
            this.name = null;
            this.color = null;
        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void SayMeow()
        {
            Console.WriteLine($"Cat {name} said: Meoooowww!");
        }
    }
}
