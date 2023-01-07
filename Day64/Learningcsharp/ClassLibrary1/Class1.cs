using System;

public class Product
{
    //Fields
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    //Constructor
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }
    public void CalculateTax()
    {
        double result;
        if (cost > 5000)
        {
            result = cost * 10 / 100;
        }
        else
        {
            result = cost * 12.5 / 100;
        }
        tax = result;
    }

    public void SetProductID(int value)
    {
        productID = value;
    }
    public int GetProductID()
    {
        return productID;
    }
    public void SetProductName(string value)
    {
        productName = value;
    }
    public string GetProductName()
    {
        return productName;
    }
    public void SetCost(double value)
    {
        cost = value;
    }
    public double GetCost()
    {
        return cost;
    }
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }
    public void SetTax(double value)
    {
        tax = value;
    }
    public double GetTax()
    {
        return tax;
    }
}