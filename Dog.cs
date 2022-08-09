using System;

class Dog : Animal {

   public Dog(string specificSound) {
        sound = specificSound;
   }

    public String Sound {
        set; get;
    }

}