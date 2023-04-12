namespace CollectionsProject
{
    public class Truck : Vehicle
    {
        public int WheelSize { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Truck\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "\n\t"+ "Wheel size: " + WheelSize);
        }
    }
}
