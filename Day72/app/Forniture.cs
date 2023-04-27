using System;

namespace Learning;

class Forniture
{
    public string Color {get; set;}
    public string Material {get; set;}
    public Forniture()
    {
        Color = "White";
        Material = "Wood";
    }

    public Forniture(string color, string material)
    {
        Color = color;
        Material = material;
    }
}