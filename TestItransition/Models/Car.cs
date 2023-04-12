namespace CollectionsProject
{
    public class Car : Vehicle
    {
        public double Weight { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Car\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                +  "\n\t" +"Weight: " + Weight);
        }
    }
}
