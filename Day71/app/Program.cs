using System;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Learning;

class Program
{
    static void Main(string[] args)
    {
        // Load the image
        Bitmap image = new Bitmap("image.jpg");

        // Resize the image
        image.SetResolution(72, 72);

        // Convert pixels to ASCII
        string asciiArt = "";
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixelColor = image.GetPixel(x, y);
                int grayscale = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                char asciiChar = GetAsciiCharacter(grayscale);
                asciiArt += asciiChar;
            }
            asciiArt += "\n";
        }

        // Display or save the ASCII art
        Console.WriteLine(asciiArt);
        // Alternatively, save it to a text file
        // using (StreamWriter writer = new StreamWriter("ascii_art.txt"))
        // {
        //     writer.Write(asciiArt);
        // }
    }

    static char GetAsciiCharacter(int grayscale)
    {
        // Map grayscale value to ASCII character
        // You can define your own mapping based on the desired ASCII characters
        char[] asciiCharacters = { ' ', '.', ':', '-', '=', '+', '*', '#', '%', '@' };
        int range = 255 / asciiCharacters.Length;
        int index = grayscale / range;
        return asciiCharacters[index];
    }

    }