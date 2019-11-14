using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using testXml.Model;

namespace testXml
{
    class Program
    {
        public static XmlSerializer xmlserialize;
        static void Main(string[] args)
        {
            Facility facility = FillFacility();
            xmlserialize = new XmlSerializer(typeof(Facility));
            SerializeObject(facility);

        }

         static void SerializeObject(Facility fac)
         {
             using (FileStream stream = new FileStream($@"C:\Users\Adrian Kaufmann\Desktop\testxml\testxml.xml",
                 FileMode.Create))
             {
                 xmlserialize.Serialize(stream, fac);
            }
            
         }

        public static Facility FillFacility()
        {
            var fac = new Facility();
            var device = new Device();
            var device2 = new Device();
            var measurepoint = new MeasurePoint();
            var measurestate = new MeasureState();
            var measurepoint2 = new MeasurePoint();
            var measurestate2 = new MeasureState();
            var measurepoint3 = new MeasurePoint();
            var measurestate3 = new MeasureState();
            var device3 = new Device();
            fac.FacilityId = "12345678";
            measurestate.AccumulDate = DateTime.Now;
            measurestate.Value = (decimal)10.5;
            measurepoint.measureState = measurestate;
            measurepoint.Medium = "Wasser";
            measurepoint.Tarif = 0;
            measurepoint.Unit = "m^3";
            device.MeasurePoints.Add(measurepoint);
            device.SRC_Id = "00001214";
            fac.Devices.Add(device);
            measurestate2.AccumulDate = DateTime.Now;
            measurestate2.Value = (decimal)19.5;
            measurepoint2.measureState = measurestate2;
            measurepoint2.Medium = "Warmwasser";
            measurepoint2.Tarif = 1;
            measurepoint2.Unit = "m^3";
            device2.MeasurePoints.Add(measurepoint2);
            device2.SRC_Id = "00001215";
            fac.Devices.Add(device2);
            measurestate3.AccumulDate = DateTime.Today;
            measurestate3.Value = (decimal)1254.54;
            measurepoint3.measureState = measurestate3;
            measurepoint3.Medium = "Elektrizität";
            measurepoint3.Tarif = 2;
            measurepoint3.Unit = "kWh";
            device3.MeasurePoints.Add(measurepoint3);
            device3.SRC_Id = "00005715";
            fac.Devices.Add(device3);

            return fac;
        }


    }
}
