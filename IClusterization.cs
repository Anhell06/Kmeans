using System.Collections.Generic;



namespace myApp
{
    public interface IClusterization<T>
    {
        ClusterizationResult<T> MakeClusterization(IList<DataItem<T>> data);
    }
}