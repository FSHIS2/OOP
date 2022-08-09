using System;

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
    }
}