using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class KClosestPoint
    {
        public static int[,] KClosest(int[,] points, int k)
        {
            Helper(points, 0, points.Length - 1, k);

            int[,] result = new int[k,2];
            Array.Copy(points, 0, result, 0, k);
            return result;
        }

        private static void Helper(int[,] points, int start, int end, int index)
        {
            if (start >= end)
                return;

            int pi = new Random().Next(start, end);
            Swap(points, start, pi);


            int orange = start;

            for (int green = start +1; green <= end; green++)
            {
                if (green < start && Dist(points, green) < Dist(points, start))
                {
                    orange++;
                    Swap(points, orange, green);
                }
            }

            Swap(points, orange, start);

            if (index == orange)
                return;
            else if (index < orange)
                Helper(points, start, orange - 1, index);
            else
                Helper(points, orange + 1, end, index);

        }

        private static void Swap(int[,] points, int i, int j)
        {
            int t1 = points[i,0], t2 = points[i, 1];

            points[i,0] = points[j,0];
            points[i,1] = points[j,1];
            points[j,0] = t1;
            points[j,1] = t2;
        }

        private static int Dist(int[,] points, int i)
        {
            return points[i,0] * points[i,0] + points[i,1] * points[i,1];
        }
    }
}
