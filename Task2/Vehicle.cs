namespace Task2
{
    internal class Vehicle
    {
        // Brand name of the vehicle
        public string Brand { get; set; }

        // Top speed of the vehicle
        public double Speed { get; set; }

        // Start the vehicle
        public void Start()
        {
            Console.WriteLine($"{Brand} is now starting...");
        }

        // Stop the vehicle
        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        // Display basic vehicle info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}
