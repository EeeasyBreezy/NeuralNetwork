using System.Collections.Generic;

namespace NeuralNetwork.Neuron
{
    /// <summary>
    /// Базовый абстрактный класс нейрона
    /// </summary>
    public abstract class BaseNeuron
    {
        #region PROPERTIES
        /// <summary>
        /// Значение на входе
        /// </summary>
        public double Input
        {
            get;
            set;
        }
        /// <summary>
        /// Значение на выходе
        /// </summary>
        public double Output
        {
            get;
            protected set;
        }
        /// <summary>
        /// Значение функции активации
        /// </summary>
        public double ActivationFunctionValue
        {
            get;
            protected set;
        }
        /// <summary>
        /// Значение производной функции активации
        /// </summary>
        public double ActivationFunctionDerivative
        {
            get;
            protected set;
        }
        /// <summary>
        /// Массив связей нейрона
        /// </summary>
        public List<Synapse> Synapses
        {
            get; set;
        }
        public List<SynapseWeight> Weights
        {
            get; set;
        }
        #endregion

        #region PUBLIC METHODS
        /// <summary>
        /// РАССЧитать функцию активации
        /// </summary>
        public abstract void LaunchActivationFunction();
        /// <summary>
        /// Рассчитать производную функии активации
        /// </summary>
        public abstract void LaunchActivationFunctionDerivative();
        #endregion
    }
    /// <summary>
    /// Входящий нейрон
    /// </summary>
    public sealed class InputNeuron : BaseNeuron
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Конструктор
        /// </summary>
        public InputNeuron()
        {
            Weights = new List<SynapseWeight>();
        }
        #endregion

        #region PUBLIC METHODS
        public override void LaunchActivationFunction()
        {
            Output = Input;
        }
        public override void LaunchActivationFunctionDerivative()
        {
        }
        #endregion
    }
    /// <summary>
    /// Внутренний нейрон
    /// </summary>
    public sealed class InnerNeuron : BaseNeuron
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Конструктор
        /// </summary>
        public InnerNeuron()
        {
            Weights = new List<SynapseWeight>();
        }
        #endregion

        #region PUBLIC METHODS
        public override void LaunchActivationFunction()
        {
        }
        public override void LaunchActivationFunctionDerivative()
        {
            
        }
        #endregion
    }
    /// <summary>
    /// Выход нейронной сети
    /// </summary>
    public sealed class OutputNeuron : BaseNeuron
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Конструктор
        /// </summary>
        public OutputNeuron()
        {
            Weights = new List<SynapseWeight>();
        }
        #endregion

        #region PUBLIC METHODS
        public override void LaunchActivationFunction()
        {
        }
        public override void LaunchActivationFunctionDerivative()
        {
        }
        #endregion
    }

}