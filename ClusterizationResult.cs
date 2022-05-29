using System.Collections.Generic;



namespace myApp
{
    public class ClusterizationResult<T>
    {
        public IList<T[]> Centroids { get; set; }
        public IDictionary<T[], IList<DataItem<T>>> Clusterization { get; set; }
        public double Cost { get; set; }
    }
}