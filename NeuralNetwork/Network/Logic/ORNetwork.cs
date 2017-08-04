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
        public BaseLogicData Data
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
        }

        public override void LaunchTeachingMethod()
        {
        }
        #endregion
    }
}
