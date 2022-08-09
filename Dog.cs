using System;

class Dog : Animal {

   public Dog(string sound) {
        this.sound = sound;
   }

    public override void makeSound()
    {
        Console.WriteLine($"The dog says {sound}");
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