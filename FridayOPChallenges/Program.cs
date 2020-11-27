using System;

namespace FridayOPChallenges
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            double lifespan;

            public Pet(string _name, int _age)
            {
                name = _name;
                age = _age;
                weight = 0.1;
                lifespan = 0;
            }

            public string Name
            {
                get { return name; }
            }

            public int Age
            {
                get { return age; }
            }
            public double Weight
            {
                get { return weight; }
            }

            public double Lifespan
            {
                get { return lifespan; }
            }

            public void Eat()
            {
                weight += 0.2;
            }

            public void Excercise()
            {
                weight -= 0.1;
            }

            public void ShowPetData()
            {
                Console.WriteLine($"Name: {name};\n Age: {age};\n Weight: {weight};\n Lifespan: {lifespan};");
            }
        }
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
   
                hunger += 0.2;
            }

            public void Meow()
            {
                Console.WriteLine("Meow meow n-word");
            }

            public void ShowCatDetails()
            {
                Console.WriteLine($"Name: {name};\n Color: {color};\n Hunger: {hunger}; ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Help Me!");
            Cat newCat = new Cat("Pätu", "Grey");
            

            while(newCat.Hunger != 1)
            {
                newCat.Sleep();
            }

            newCat.ShowCatDetails();

            newCat.Meow();

            Pet newPet = new Pet("Heavy", 0);

            newPet.ShowPetData();






        }
    }
}
