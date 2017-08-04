namespace NeuralNetwork.Network.Logic
{
    public abstract class BaseLogicData
    {
        #region PROPERTIES
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }
        public int Answer
        {
            get; set;
        }
        #endregion
    }

    public sealed class ORData : BaseLogicData
    {
        public ORData(int x, int y)
        {
            X = x;
            Y = y;
            Answer = X | Y;
        }
    }
    public sealed class ANDData : BaseLogicData
    {
        public ANDData(int x, int y)
        {
            X = x;
            Y = y;
            Answer = x & y;
        }
    }
    public sealed class XORData : BaseLogicData
    {
        public XORData(int x, int y)
        {
            X = x;
            Y = y;
            Answer = x ^ y;
        }
    }
}
