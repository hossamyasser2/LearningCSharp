using System;
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Speed = 100000000;
        System.Console.WriteLine(car.Speed);



    }
}
class Car
{
    private int speed;
    public Car (int speed)
    {
        Speed = speed;
    }
        public int Speed
    {
        get {return speed;}
        set
        {
            if(value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        }
    }
}