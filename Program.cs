using System;
using MySpace;
using System.IO;

/*Sealed keyword indicates that class
cannot be inherited*/
sealed class Program {
    static void Main(String[] args) {
        Pig pig = new Pig("oink oink");
        Dog dog = new Dog("guau guau");
        pig.makeSound();
        dog.makeSound();
        pig.Sound = "wee wee";
        Console.WriteLine(pig.Sound);
        pig.sleep();
        dog.sleep();
        pig.feed();
        dog.feed();
        Number pigs = Number.Three;
        Number dogs = Number.Five;
        Console.WriteLine(pigs);
        Console.WriteLine(dogs);
        try
        {
            string readText = File.ReadAllText("Animal.txt");
            Console.WriteLine(readText);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("This is an excellent OOP kata");
        }
    }
}