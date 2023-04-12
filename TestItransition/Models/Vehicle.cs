using System.Xml.Serialization;
using TestItransition.Models;

namespace CollectionsProject
{
    
    [XmlInclude(typeof(Car), Type = typeof(Car))]
    [XmlInclude(typeof(Bus), Type = typeof(Bus))]
    [XmlInclude(typeof(Scooter), Type = typeof(Scooter))]
    [XmlInclude(typeof(Truck), Type = typeof(Truck))]
    [Serializable]
    public class Vehicle
    {
        [XmlElement]
        public Engine Engine { get; set; }
        [XmlElement]
        public Chassis Chassis { get; set; }
        [XmlElement]
        public Transmission Transmission { get; set; }
    }
}
