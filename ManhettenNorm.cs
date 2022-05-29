using System;



namespace myApp
{
    internal class ManhettenNorm : MetricsBase<double>
    {

        public override double Calculate(double[] v1, double[] v2)
        {
            if (v1.Length != v2.Length)
            {
                throw new ArgumentException("Vectors dimensions are not same");
            }
            if (v1.Length == 0 || v2.Length == 0)
            {
                throw new ArgumentException("Vector dimension can't be 0");
            }
            double d = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                d += Math.Abs(v1[i] - v2[i]);
            }
            return d;
        }

    }
}