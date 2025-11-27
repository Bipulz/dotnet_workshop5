namespace Task2
{
    internal class Bike : Vehicle
    {
        // Number of seats available on the bike
        public int Seats { get; set; }

        // Display specific bike information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats Available on Bike: {Seats}");
        }
    }
}
