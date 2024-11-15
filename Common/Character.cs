using Enumerations;
using Interfaces;
using Melee;
using System;

namespace Common
{
    public abstract class Character
    {
        private string name;
        private int level, age;
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

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Character() { }
        public Character(string name, int level, int age)
        {
            this.Name = name;
            this.Level = level;
            this.Age = age;
        }

        public void Greeting(string name)
        {
            Console.WriteLine($"Hi from: {name}");
        }

        protected void CharacterAttributes()
        {

            Console.WriteLine($"Name: {Name}\n" +
                $"Level: {Level}\n" +
                $"Age: {Age}\n" +
                $"Health: {HitPoints.Health}");
        }

        public abstract int Addition(int firstNum, int secondNum);
    }
}
