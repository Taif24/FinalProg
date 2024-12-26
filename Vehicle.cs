public class Vehicle{
    public string name {get; set;}
    private int speed {get; set;}
    public static int TotalVehicles;

    public Vehicle(string name, int speed){
        this.name = name;
        this.speed = speed;
        TotalVehicles++;
    }

    public virtual void Start(){
        Console.WriteLine("Vehicle is starting!");
    }
    public virtual void Accelerate(int increment){
        speed = increment;
        Console.WriteLine(increment);
    }
    public int  GetSpeed(){
        return speed;
    }
}