using System;
class Program
{
    static void Main(string[] args)
    {
        String name = PlanetRadius.Earth.ToString();
        System.Console.WriteLine($"Planet: {name}");
        System.Console.WriteLine($"Radius: {(int)PlanetRadius.Earth}");
        double volume = Volume(PlanetRadius.Earth);
        System.Console.WriteLine($"Volume: {volume}");

    }
    public static double Volume(PlanetRadius radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }
}
enum Planets
{
    Mercury,
    Venus,
    Earth,
    Mars,
    Jupiter,
    Uranus,
    Neptune,
    Pluto
}
enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
}