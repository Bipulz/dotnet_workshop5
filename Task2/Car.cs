namespace Task2
{
    internal class Car : Vehicle
    {
        // Number of doors on the car
        public int Doors { get; set; }

        // Display specific car information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {Doors}");
        }
    }
}
