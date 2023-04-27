using System;
namespace Learning;



class Program
{
    static void Main(string[] args)
    {
        Chair officeChair = new Chair("Brown", "Plastic");
        Chair gamingChair = new Chair("Red", "Wood");

        Car damagedCar = new Car(80F, "Blue");

        damagedCar.DestroyablesNearby.Add(officeChair);
        damagedCar.DestroyablesNearby.Add(gamingChair);

        damagedCar.Destroy();
    }
}