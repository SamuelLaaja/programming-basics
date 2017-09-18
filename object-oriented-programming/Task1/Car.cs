using System;

public class Car
{
    // Underline is preferred formatting style for class variables
    private string _originalColor;
    private double _speed;

    // Properties. Brand cannot be changed.
    public string Brand { get; }

    public double Speed { 
    get { return _speed; }
    set {
            if (value >= 0)
                _speed = value;
        }
    }

    public string Color { get; set; }


    //Constructor
    public Car(string Brand = "Ford", double Speed = 80, string Color = "Red")
    {
        // 'this.' is needed when variables use the same name. 'this.' refers to the current class.
        this.Brand = Brand;
        this.Speed = Speed;
        this.Color = Color;
        _originalColor = "Blue";
    }

    //Default constructor
    public Car()
    {
        Brand = "Ford";
        Speed = 80;
        Color = "Red";
        _originalColor = "Red";
    }
    
    // Shows info about created Car Object
    public void ShowInfo()
    {
        Console.WriteLine("Car brand: " + Brand);
        Console.WriteLine("Speed: " + Speed);
        Console.WriteLine("Original color: " + _originalColor);
        Console.WriteLine();
    }

    // Overrides what Object method Car.ToString() outputs.
    public override string ToString()
    {
        // Quicker way to insert variables to a string
        return $"Brand: {Brand}, Color: {Color}, Original color: {_originalColor}, Speed: {Speed}\n";
    }


    public void Accelerate(double value)
    {
        Console.WriteLine($"Accelerating {Brand}!\n");
        Speed += value;
    }

    // Accelerate with default value, alternate way for (double value = 10).
    public void Accelerate()
    {
        Console.WriteLine($"Accelerating {Brand}!\n");
        Speed += 10;
    }

    public void Decelerate(double value)
    {
        //Stops at 0 value
        Speed = Math.Max(0, Speed - value);
    }
}

