﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Add parts: ");

Car car = new Car();
// CarPart carPart = new CarPart();
//car.AddCarPart(carPart);

Engine engine6000 = new Engine(500);
car.AddCarPart(engine6000);
engine6000.SomeInt();

//Console.WriteLine(carPart.partName);
//Console.WriteLine(((CarPart)engine6000).ToString());
//Console.WriteLine(engine6000.GetCost());

PartTest(engine6000);

Console.ReadLine();

void PartTest (CarPart carpart) {
    Console.WriteLine(carpart.ToString());
}

static string Describe(object someObject) {
    if (someObject is int || someObject is double || someObject is decimal) {
        return $"{someObject.GetType()} of value {someObject}";
    } else return null;
}

public enum Season {
    Spring,
    Summer,
    Autumn,
    Winter,
    None,
    PLASMA
}

public class Car {
    private List<CarPart> _carParts = new List<CarPart>();
    public void AddCarPart(CarPart carPart) {
        _carParts.Add(carPart);
    }
}

public class CarPart {
    protected int Cost { get; set; }
    protected CarPart(int cost)
    {
        
    }
    protected virtual string partName => "Some part name";
    public override string ToString() {
        return $"{partName}";
    }

    public int SomeInt() { return 1; }
}

public class Engine : CarPart {
    public Engine(int cost) : base(cost) {
        Cost = cost;
    }

    protected override string partName => "engine";
    public override string ToString() {
        return $"This part is called {partName} from base class abstraction: {base.partName}";
    }

    public string GetCost() {
        return $"{base.partName} called {this.partName} costs {this.Cost}";
    }

}
