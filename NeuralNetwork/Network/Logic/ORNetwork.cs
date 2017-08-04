using System.Collections.Generic;
using NeuralNetwork.Neuron;

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
        }

        public override void InitNetwork(int inputNeuronsDim, int innerLayers, int[] dimPerLayer, int outputDim)
        {
            inputNeurons = new List<InputNeuron>(inputNeuronsDim);
            for(int i = 0; i < inputNeurons.Capacity; i++)
                inputNeurons.Add(new InputNeuron());
            innerNeurons = new List<List<InnerNeuron>>(innerLayers);
            for (int i = 0; i < innerNeurons.Capacity; i++)
            {
                innerNeurons[i] = new List<InnerNeuron>(dimPerLayer[i]);
                for (int j = 0; j < innerNeurons[i].Capacity; j++)
                    innerNeurons[i].Add(new InnerNeuron());
            }
            outputNeurons = new List<OutputNeuron>(outputDim);
            for (int i = 0; i < outputNeurons.Capacity; i++)
                outputNeurons.Add(new OutputNeuron());
        }

        public override void LaunchTeachingMethod()
        {
        }
        #endregion
    }
}
