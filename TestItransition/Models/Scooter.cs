

namespace CollectionsProject
{
    public class Scooter : Vehicle
    {
        public bool ExtraSeat { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Scooter\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "\n\t"+"Is extra seat exist: " + ExtraSeat);
        }
    }
}
