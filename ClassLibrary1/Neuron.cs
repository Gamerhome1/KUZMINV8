using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Neuron : SynapticNode
    {
        public string NeuralLayer { get; set; }
        public string ActivationFunction { get; set; }
        public string ThresholdValue { get; set; }
        public LayersOfNeurons LayersOfNeurons { get;set; }
    }
}
