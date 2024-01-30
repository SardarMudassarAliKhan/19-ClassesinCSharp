using System;

// Define a class named Car
class Car
{
    // Properties (fields) of the Car class
    public string Make;
    public string Model;
    public int Year;

    // Constructor method to initialize the Car object
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Method to display information about the car
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object (instance) of the Car class
        Car myCar = new Car("Toyota", "Camry", 2022);

        // Calling a method of the Car class to display information about the car
        myCar.DisplayInfo();
    }
}
