using System;

class Animal {
    
    protected string sound = "";

    public void makeSound() {
        //String interpolation
        Console.WriteLine($"This animal says {sound}");
    }

}