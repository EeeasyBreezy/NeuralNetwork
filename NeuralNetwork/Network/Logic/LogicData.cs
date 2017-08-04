namespace NeuralNetwork.Network.Logic
{
    /// <summary>
    /// наборы данных для логических операций
    /// </summary>
    public class LogicData
    {
        #region PROPERTIES
        /// <summary>
        /// Первый аргумент операции
        /// </summary>
        public int X
        {
            get;
            private set;
        }
        /// <summary>
        /// Второй аргумент операции
        /// </summary>
        public int Y
        {
            get;
            private set;
        }
        /// <summary>
        /// Ответ операции
        /// </summary>
        public int Answer
        {
            get;
            private set;
        }
        #endregion

        #region PUBLIC METHODS
        /// <summary>
        /// Логическое ИЛИ
        /// </summary>
        /// <param name="x">Первый аргумент</param>
        /// <param name="y">Второй аргумент</param>
        public void Or(int x, int y)
        {
            X = x; Y = y; Answer = x | y;
        }
        /// <summary>
        /// Логическое И
        /// </summary>
        /// <param name="x">Первый аргумент</param>
        /// <param name="y">Второй аргумент</param>
        public void And(int x, int y)
        {
            X = x; Y = y; Answer = x | y;
        }
        /// <summary>
        /// Исключающее ИЛИ
        /// </summary>
        /// <param name="x">Первый аргумент</param>
        /// <param name="y">Второй аргумент</param>
        public void Xor(int x, int y)
        {
            X = x; Y = y; Answer = x ^ y;
        }
        #endregion

    }
}
