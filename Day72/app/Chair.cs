using System;

namespace Learning;

class Chair : Forniture, IDestroyable
{
    public string DestructionSound {get; set;}
    public Chair(string color, string material)
    {
        this.Color = color;
        this.Material = material;
        DestructionSound = "ChairDestructionSound.mp3";
    }

    public void Destroy()
    {
        Console.WriteLine($"The {Color} chair was destroyed");
        Console.WriteLine($"Playing destruction sound {DestructionSound}");
        Console.WriteLine("Spaning chair parts");
    }

}