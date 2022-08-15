using System;

namespace MySpace;

enum Number {
    Three,
    Four,
    Five
}

abstract class Animal {
    
    protected string sound = "";

    protected Animal(string sound)
    {
        this.sound = sound;
    }

    public abstract void makeSound();
    public void sleep() {
        Console.WriteLine("Zzz");
    }

}