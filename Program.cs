class Program{

    public static void Main(string[] args){

        Vehicle[] v = new Vehicle[3];

        Car c = new Car("Audi" , 200);
        Motorcycle m = new Motorcycle("Suzuki", 300);
        Truck t = new Truck("isuzo", 100);
        v[0] = c;
        v[1] = m;
        v[2] = t;

        for(int i = 0; i <v.Length; i++){
            v[i].Start();
        }

        v[0].Accelerate(10);
        v[1].Accelerate(20);
        v[2].Accelerate(15);

        for(int i = 0; i <v.Length; i++){
            v[i].GetSpeed();
        }

        Console.WriteLine("Total vehicles created:" + Vehicle.TotalVehicles);
    }
}