using CollectionsProject;

namespace TestItransition.Models
{
    public class Bus : Vehicle
    {
        public int NumOfSeats { get; set; }



        public void GetInfo()
        {
            Console.WriteLine("Bus\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "\n\t" + "Number of seats: " + NumOfSeats);
        }
    }
}
