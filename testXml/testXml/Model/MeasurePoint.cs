using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testXml.Model
{
    public class MeasurePoint
    {
        public int Tarif { get; set; }
        public string Unit { get; set; }
        public string Medium { get; set; }

        public MeasureState measureState { get; set; }

    }
}
