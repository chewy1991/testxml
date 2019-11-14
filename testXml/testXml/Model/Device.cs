using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testXml.Model
{
    public class Device
    {
        public string SRC_Id { get; set; }
        public List<MeasurePoint> MeasurePoints = new List<MeasurePoint>();
    }
}
