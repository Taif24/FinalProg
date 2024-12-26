public class Car : Vehicle{
    public int FuelEfficiency;

    public Car(string name, int speed) : base(name, speed)
    {
    }

    public override void Start(){
        Console.WriteLine("The car is starting with a smooth engine sound!");
    }
}