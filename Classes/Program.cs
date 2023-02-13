namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2018;
            Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
        }
    }
}
