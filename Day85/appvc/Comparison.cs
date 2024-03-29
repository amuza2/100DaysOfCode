public class Comparison
{
    private readonly Func<Car, Double> _valueSelected;
    public double Yesterday { get; private set; }
    public double Today { get; private set; }
    public double Difference { get; private set; }
    public Comparison(Func<Car, double> valueSelected)
    {
        _valueSelected = valueSelected;
    }
    public void Compare(Car yesterdayCar, Car todayCar)
    {
        Yesterday = _valueSelected(yesterdayCar);
        Today = _valueSelected(todayCar);
        Difference = Yesterday - Today;
    }
}