using System.Xml.Serialization;
using TestItransition.Models;

namespace CollectionsProject;


public  class RecordDataToXml
{
   public static void Main()
   {
      VehicleData vehicleData = new VehicleData();
      var transportVehicles = vehicleData.TransportObjects().Where(v => v.Engine.Capacity > 1.5);
      var trucksAndBuses    = vehicleData.TransportObjects().Where(v => v is Bus || v is Truck);
      var results = trucksAndBuses.Select(v => new { Power = v.Engine.Power, SerialNumber = v.Engine.SerialNumber });
      var groupVehicles = vehicleData
         .TransportObjects().GroupBy(v => v.Transmission);
      
      
      XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>));
      using (TextWriter writer = new StreamWriter(@"D:\My\Projects\OOP\CollectionsProject\vehicles.xml"))
      {
         serializer.Serialize(writer, transportVehicles.ToList());
      }

      using (TextWriter writer = new StreamWriter(@"D:\My\Projects\OOP\CollectionsProject\truckAndBuses.xml"))
      {
         serializer.Serialize(writer,results.ToList());
      }
      
      using (TextWriter writer = new StreamWriter(@"D:\My\Projects\OOP\CollectionsProject\groupVehicle.xml"))
      {
         serializer.Serialize(writer,groupVehicles.ToList());
      }
   }
}