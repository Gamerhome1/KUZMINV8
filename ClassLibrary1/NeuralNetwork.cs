namespace ClassLibrary1
{
    public class NeuralNetwork
    {
        public LayersOfNeurons Layers { get; set; }
        public OutputVector OutputVector { get; set; }
        public InputVector InputVector { get; set; }
        
        public NeuralNetwork()
        {
            OutputVector = new OutputVector();
            InputVector = new InputVector();
            Layers = new LayersOfNeurons();
        }
    }
}