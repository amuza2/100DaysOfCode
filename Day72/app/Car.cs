using System;
namespace Learning;

class Car : Vehicule, IDestroyable
{
    public string DestructionSound {get; set;}
    public List<IDestroyable> DestroyablesNearby;
    public Car(float speed, string color):base(speed, color)
    {
        DestructionSound = "CarExplosionSound.mp3";
        DestroyablesNearby = new List<IDestroyable>();
    }
    public void Destroy()
    {
        Console.WriteLine($"Playing destruction sould {DestructionSound}");
        Console.WriteLine("Create fire");
        foreach(IDestroyable destroyable in DestroyablesNearby)
        {
            destroyable.Destroy();
        }
    }

}