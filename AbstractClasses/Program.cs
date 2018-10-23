using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList animalList = new ArrayList();
            animalList.Add(new Dog());
            animalList.Add(new Cat());

            foreach (FourLeggedAnimal animal in animalList)
            {
                Console.WriteLine(animal.Describe());
                Console.ReadKey();
            }

        }

        abstract class FourLeggedAnimal
        {
            public int serialNumber;

            public virtual string Describe()
            {
                return "Not much is known about this animal. Though, it does have four legs.";
            }

            public int SerialNumber
            {
                get { return serialNumber; }
                set { serialNumber = value; }
            }

        }

        class Dog : FourLeggedAnimal
        {
            public override string Describe()
            {
                string result;
                result = " This is now a dog.";
                return result;
            }
        }
        class Cat : FourLeggedAnimal
        {
            public override string Describe()
            {
                string result;
                result = " This is now a cat.";
                return result;
            }
        }

        class Giraffe : FourLeggedAnimal
        {
            public override string Describe()
            {
                string result = "I am a giraffe.";
                return result;
            }
            
        }

        
    }
}
