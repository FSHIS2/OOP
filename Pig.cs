using System;

class Pig : Animal {

    public Pig(string sound) {
        this.sound = sound;
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

}