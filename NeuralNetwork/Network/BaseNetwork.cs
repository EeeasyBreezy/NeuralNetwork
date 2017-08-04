using System.Collections.Generic;
using NeuralNetwork.Neuron;

namespace NeuralNetwork.Network
{
    /// <summary>
    /// Базовый класс для нейронной сети
    /// </summary>
    public abstract class BaseNetwork
    {
        #region DATA
        /// <summary>
        /// Входные нейроны
        /// </summary>
        protected List<InputNeuron> inputNeurons;
        /// <summary>
        /// Внутренние нейроны
        /// </summary>
        protected List<List<InnerNeuron>> innerNeurons;
        /// <summary>
        /// Выходные нейроны
        /// </summary>
        protected List<OutputNeuron> outputNeurons;
        #endregion

        #region PUBLIC METHODS
        /// <summary>
        /// Инициализировать нейронную сеть
        /// </summary>
        /// <param name="inputNeuronsDim">Количество входов</param>
        /// <param name="innerLayers">Количество внутренних слоев</param>
        /// <param name="dimPerLayer">Количество нейронов в каждом внутреннем слое</param>
        /// <param name="outputDim">Количество выходов</param>
        public abstract void InitNetwork(int inputNeuronsDim, int innerLayers, int[] dimPerLayer, int outputDim);
        /// <summary>
        /// Рассчитать результат
        /// </summary>
        public abstract void CalculateResult();
        /// <summary>
        /// Посчитать ошибку
        /// </summary>
        public abstract void CalculateError();
        /// <summary>
        /// Запустить обучение
        /// </summary>
        public abstract void LaunchTeachingMethod();
        #endregion
    }
}
