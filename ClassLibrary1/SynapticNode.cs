using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SynapticNode
    {
        public Synapse InputSynapses { get; set; }
        public Synapse OutputSynapses { get; set; }
        private string Meaning { get; set; }
        private string Features { get; set; }
        public SynapticNode()
        {
            InputSynapses = new Synapse();
            OutputSynapses = new Synapse();
        }
    }
}
