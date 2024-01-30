In C#, a class is a blueprint or template for creating objects (instances) of that class. It defines the properties, methods, events, and other members that the objects of the class will have. Here's a basic example of a class in C#:

```csharp
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
```

In this example:

- We define a class named `Car` with three properties: `Make`, `Model`, and `Year`.
- We have a constructor method `Car` which is called when an object of the `Car` class is created. It initializes the properties of the `Car` object.
- We have a method `DisplayInfo` which displays information about the car.
- In the `Main` method, we create an object `myCar` of the `Car` class using the `new` keyword and provide values for its properties.
- We then call the `DisplayInfo` method on the `myCar` object to display its information.

Classes are fundamental to object-oriented programming in C# as they allow you to encapsulate data and behavior into reusable components.
