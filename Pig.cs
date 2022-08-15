using System;
using MySpace;

class Pig : Animal, IMammal {

    public Pig(string sound) : base(sound){
    }

    public override void makeSound()
    {
        Console.WriteLine($"The pig says {sound}");
    }

    public string Sound {
        get {
            return this.sound;
        }

        set {
            this.sound = value;
        }
    }

    public void feed() {
        Console.WriteLine("Feeding piglets");
    }

}