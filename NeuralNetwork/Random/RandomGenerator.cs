using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SystemRandom = System.Random;

namespace NeuralNetwork.Random
{
    public static class RandomGenerator
    {
        private static SystemRandom rand = new SystemRandom();

        public static double GetDouble(double bottom, double top)
        {
            if (bottom > top)
                throw new ArgumentException("Неверные значения отрезка");
            double result = bottom + rand.NextDouble() * (top - bottom);
            return result;
        }
    }
}
