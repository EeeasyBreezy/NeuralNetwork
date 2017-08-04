namespace NeuralNetwork.Neuron
{
    /// <summary>
    /// Синапс нейрона
    /// </summary>
    public sealed class Synapse
    {
        #region PROPEERTIES
        /// <summary>
        /// Вес синапса
        /// </summary>
        public SynapseWeight Weight
        {
            get; set;
        } 
        /// <summary>
        /// Нейрон, в который входит этот синапс
        /// </summary>
        public BaseNeuron SynapseDestination
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Конструктор
        /// </summary>
        public Synapse()
        {
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="weight">Вес синапса</param>
        /// <param name="synapseDestination">Точка входа синапса</param>
        public Synapse(SynapseWeight weight, BaseNeuron synapseDestination)
        {
            Weight = weight;
            SynapseDestination = synapseDestination;
        }
        #endregion
    }
}
