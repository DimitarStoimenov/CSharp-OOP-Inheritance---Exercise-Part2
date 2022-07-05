namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputType;
            List<Animal> animalsList = new List<Animal>();
            
            while ((inputType = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    string[] rawCommand = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string animalName = rawCommand[0];
                    int animalAge = int.Parse(rawCommand[1]);

                    Animal animal = null;

                    if (inputType == "Dog")
                    {
                        string animalGender = rawCommand[2];
                        animal = new Dog(animalName, animalAge, animalGender);

                    }
                    else if (inputType == "Frog")
                    {
                        string animalGender = rawCommand[2];
                        animal = new Frog(animalName, animalAge, animalGender);

                    }
                    else if (inputType == "Cat")
                    {
                        string animalGender = rawCommand[2];
                        animal = new Cat(animalName, animalAge, animalGender);
                    }
                    else if (inputType == "Kitten")
                    {
                        animal = new Kitten(animalName, animalAge);
                    }
                    else if (inputType == "Tomcat")
                    {
                        animal = new Tomcat(animalName, animalAge);
                    }
                    else
                    {
                        throw new InvalidOperationException("Ivnalid type");
                    }
                    animalsList.Add(animal);
                    
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input");
                }
                
            }

            foreach (var item in animalsList)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
