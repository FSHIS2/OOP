using System;

abstract class Animal {
    
    protected string sound = "";

    public abstract void makeSound();
    public void sleep() {
        Console.WriteLine("Zzz");
    }

}