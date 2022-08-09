using System;

/*Sealed keyword indicates that class
cannot be inherited*/
sealed class Program {
    static void Main(String[] args) {
        Animal animal = new Dog();
        animal.sound();
    }
}