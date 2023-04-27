using System;

namespace Learning;

class Vehicule
{
    public float Speed {get; set;}
    public string Color {get; set;}

    public Vehicule()
    {
        Speed = 120f;
        Color = "White";
    }
    public Vehicule(float speed, string color)
    {
        Speed = speed;
        Color = color;
    }
}