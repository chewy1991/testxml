using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testXml.Model
{
    [Serializable]
    public class MeasureState
    {
        public DateTime AccumulDate { get; set; }
        public decimal Value { get; set; }
    }
}
