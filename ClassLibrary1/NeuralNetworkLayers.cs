using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NeuralNetworkLayers
    {
        public SynapticNode SynapticNode { get; set; }
        public int Elements { get; set; }
        public string NeuralNetwork { get; set; }
        public NeuralNetworkLayers() 
        {
            SynapticNode = new SynapticNode();   
        
        }
    
    }
}
