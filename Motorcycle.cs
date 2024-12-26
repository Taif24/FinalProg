public class Motorcycle : Vehicle
{
    public Motorcycle(string name, int speed) : base(name, speed)
    {
    }
    public override void Start(){
        Console.WriteLine("The motorcycle roars to life!");
    }

    public override void Accelerate(int increment){
        Console.WriteLine(increment * 2);
    }
}