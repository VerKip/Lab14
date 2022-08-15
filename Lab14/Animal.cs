using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    abstract class Bars
    {
        public abstract string Name { get; set; }

        public Bars (string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Bars
    {
        private string say;
        private string name;
        public override string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public Cat(string name, string say)
            :base(name)
        {
            this.say = say;
        }
        public override void Say()
        {
            Console.WriteLine(say);
        }
    }

    class Dog : Bars
    {
        private string say;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
            : base(name)
        {
            this.say = say; 
        }
        public override void Say()
        {
            Console.WriteLine(say);
        }
    }
}
