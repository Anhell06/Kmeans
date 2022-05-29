using System.Collections.Generic;



namespace myApp
{
    public interface IMetrics<T>
    {
        double Calculate(T[] v1, T[] v2);

        T[] GetCentroid(IList<T[]> data);
    }
}