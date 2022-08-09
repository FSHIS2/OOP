using System;

class Pig : Animal {

    public Pig(string specificSound) {
        sound = specificSound;
    }

    public String Sound {
        get {
            return sound;
        }

        set {
            sound = value;
        }
    }

}