namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Vehicle Information System (Task 2) ===\n");

            // Bike details
            Bike bike = new Bike
            {
                Brand = "Pulsar 220",
                Speed = 20.5,
                Seats = 2
            };

            bike.Start();
            bike.DisplayInfo();
            bike.Stop();

            Console.WriteLine("\n------------------------------------------\n");

            // Car details
            Car car = new Car
            {
                Brand = "Maruti 800",
                Speed = 80.0,
                Doors = 4
            };

            car.Start();
            car.DisplayInfo();
            car.Stop();
        }
    }
}
