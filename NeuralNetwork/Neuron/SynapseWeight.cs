namespace NeuralNetwork.Neuron
{
    /// <summary>
    /// Вес нейрона
    /// </summary>
    public sealed class SynapseWeight
    {
        #region PROPERTIES
        /// <summary>
        /// Значение веса
        /// </summary>
        public double Value
        {
            get; set;
        }
        /// <summary>
        /// Измленение на прошлой итерации
        /// </summary>
        public double LastChange
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value">Значение веса</param>
        public SynapseWeight(double value)
        {
            Value = value;
        }
        #endregion
    }
}
