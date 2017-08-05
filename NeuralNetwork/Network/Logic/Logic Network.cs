using System.Collections.Generic;
using System.Linq;
using NeuralNetwork.Neuron;
using NeuralNetwork.Random;

namespace NeuralNetwork.Network.Logic
{
    /// <summary>
    /// Нейронная сеть для расчета логических операций
    /// </summary>
    public sealed class LogicNetwork : BaseNetwork
    {
        #region PROPERTIES
        /// <summary>
        /// Текущие данные на данной операции
        /// </summary>
        public LogicData Data
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Конструктор
        /// </summary>
        public LogicNetwork()
        {
        }
        #endregion

        #region PUBLIC METHODS
        public override void CalculateError()
        {
        }
        public override void CalculateResult()
        {
            for (int i = 0; i < inputNeurons.Count; i++)
                inputNeurons[i].LaunchActivationFunction();
        }
        public override void InitNetwork(int inputNeuronsDim, int innerLayers, int[] dimPerLayer, int outputDim)
        {
            inputNeurons = new List<InputNeuron>(inputNeuronsDim);
            innerNeurons = new List<List<InnerNeuron>>(innerLayers);
            for (int i = 0; i < innerNeurons.Count; i++)
                innerNeurons[i] = new List<InnerNeuron>(dimPerLayer[i]);
            outputNeurons = new List<OutputNeuron>(outputDim);
            for (int i = 0; i < inputNeurons.Count; i++)
                for (int j = 0; j < innerNeurons[0].Count; j++)
                    inputNeurons[i].Weights.Add(new SynapseWeight(RandomGenerator.GetDouble(-3, 3)));
            for (int i = 0; i < innerNeurons.Count - 1; i++)
                for (int j = 0; j < innerNeurons[i].Count; j++)
                    for (int k = 0; k < innerNeurons[i + 1].Count; k++)
                        innerNeurons[i][j].Weights.Add(new SynapseWeight(RandomGenerator.GetDouble(-3.0, 3.0)));
            for (int i = 0; i < innerNeurons[innerNeurons.Count - 1].Count; i++)
                for (int j = 0; j < outputNeurons.Count; j++)
                    innerNeurons[innerNeurons.Count - 1][i].Weights.Add(new SynapseWeight(RandomGenerator.GetDouble(-3.0, 3.0)));
        }
        public override void LaunchTeachingMethod()
        {
        }
        #endregion
    }
}
