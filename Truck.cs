public class Truck : Vehicle
{
    public int CargoCapacity;
    public Truck(string name, int speed) : base(name, speed)
    {
    }

    public override void Start(){
        Console.WriteLine("The truck's heavy engine rumbles as it starts!");
    }
}