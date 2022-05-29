using System;
using System.Collections.Generic;
using System.Linq;



namespace myApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int _maxIterations = 100000;
            int _countOfCluster = 2;
            Dictionary<int, List<DataItem<double>>> fullData = new Dictionary<int, List<DataItem<double>>>();



            KMeans clusterization = new KMeans(_countOfCluster, new EuclideanDistance(), _maxIterations);
            Dictionary<double, double[]> classItem = new Dictionary<double, double[]>();
            ClusterizationResult<double> c = clusterization.MakeClusterization(StaticData.Data); // запуск кластеризации
            Console.WriteLine("Евклидово расстояние");

            foreach (var kvp in c.Clusterization)
            {
                Console.WriteLine("Центр масс: (" + kvp.Key[0] + ", " + kvp.Key[1] + ", " + kvp.Key[2] + ") : \n точки кластера:");
                foreach (var str in kvp.Value.ToList<DataItem<double>>())
                {
                    Console.WriteLine(" (" + str.Input[0] + ", " + str.Input[1] + ", " + str.Input[2] + ")");
                }
            }

            Console.WriteLine("Манхеттенская норма");

            clusterization = new KMeans(_countOfCluster, new ManhettenNorm(), _maxIterations);
            classItem = new Dictionary<double, double[]>();
            c = clusterization.MakeClusterization(StaticData.Data); // запуск кластеризации

            foreach (var kvp in c.Clusterization)
            {
                Console.WriteLine("Центр масс: (" + kvp.Key[0] + ", " + kvp.Key[1] + ", " + kvp.Key[2] + ") : \n точки кластера:");
                foreach (var str in kvp.Value.ToList<DataItem<double>>())
                {
                    Console.WriteLine(" (" + str.Input[0] + ", " + str.Input[1] + ", " + str.Input[2] + ")");
                }
            }

            Console.ReadKey();
        }

    }
}
