// See https://aka.ms/new-console-template for more information
Console.WriteLine("Add parts: ");

Car car = new Car();
// CarPart carPart = new CarPart();
//car.AddCarPart(carPart);

CarPart engine6000 = new Engine();
car.AddCarPart(engine6000);

//Console.WriteLine(carPart.partName);
Console.WriteLine(((CarPart)engine6000).partName);
Console.ReadLine();

public class Car {
    private List<CarPart> _carParts = new List<CarPart>();
    public void AddCarPart(CarPart carPart) {
        _carParts.Add(carPart);
    }
}

public abstract class CarPart {
    public virtual string partName => "Some part name";
}

public class Engine : CarPart {
    public override string partName => "I'm an engine";
}
