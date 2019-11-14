using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testXml.Model
{
    [Serializable]
    public class Facility
    {
        public List<Device> Devices = new List<Device>();
        public string FacilityId { get; set; }
        
    }
}
