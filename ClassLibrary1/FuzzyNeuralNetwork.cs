using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FuzzyNeuralNetwork : NeuralNetwork
    {
        public int  CountOfClasses { get; set; }  
        public int CountOfRules { get; set; }
        public string Centers { get; set; }
    }
}
