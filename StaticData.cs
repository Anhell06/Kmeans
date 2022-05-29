using System.Collections.Generic;



namespace myApp
{
    public static class StaticData
    {
        public static List<DataItem<double>> Data = new List<DataItem<double>>();
        static StaticData()
        {
            Data.Add(new DataItem<double>(new double[3] { 1, 2, 15 }));
            Data.Add(new DataItem<double>(new double[3] { 5, 18, 4 }));
            Data.Add(new DataItem<double>(new double[3] { -10, -3, 6 }));
            Data.Add(new DataItem<double>(new double[3] { 18, 15, 14 }));
            Data.Add(new DataItem<double>(new double[3] { 2, 19, -13 }));
            Data.Add(new DataItem<double>(new double[3] { -3, 5, -33 }));
            Data.Add(new DataItem<double>(new double[3] { 13, 5, 12 }));
            Data.Add(new DataItem<double>(new double[3] { 6, 11, 1 }));
            Data.Add(new DataItem<double>(new double[3] { -7, -2, 2 }));
            Data.Add(new DataItem<double>(new double[3] { 14, 13, 11 }));
            Data.Add(new DataItem<double>(new double[3] { 4, 20, -11 }));
            Data.Add(new DataItem<double>(new double[3] { -5, 8, -21 }));
            Data.Add(new DataItem<double>(new double[3] { -5, -3, 2 }));
            Data.Add(new DataItem<double>(new double[3] { 16, 19, 20 }));
            Data.Add(new DataItem<double>(new double[3] { 11, 5, 19 }));
            Data.Add(new DataItem<double>(new double[3] { 9, 10, 4 }));
            Data.Add(new DataItem<double>(new double[3] { -7, 0, 3 }));
            Data.Add(new DataItem<double>(new double[3] { 13, 14, 15 }));
            Data.Add(new DataItem<double>(new double[3] { 12, 19, -17 }));
            Data.Add(new DataItem<double>(new double[3] { -5, 9, -30 }));
            Data.Add(new DataItem<double>(new double[3] { 20, 7, 20 }));
            Data.Add(new DataItem<double>(new double[3] { 0, 19, 9 }));
            Data.Add(new DataItem<double>(new double[3] { -6, -1, 2 }));
            Data.Add(new DataItem<double>(new double[3] { 13, 11, 18 }));
            Data.Add(new DataItem<double>(new double[3] { 0, 15, -20 }));
            Data.Add(new DataItem<double>(new double[3] { -2, 6, -24 }));
            Data.Add(new DataItem<double>(new double[3] { 11, 4, 15 }));
            Data.Add(new DataItem<double>(new double[3] { 3, 15, 6 }));
            Data.Add(new DataItem<double>(new double[3] { 0, 0, 9 }));
            Data.Add(new DataItem<double>(new double[3] { 7, 8, 0 }));
        }
    }
}
