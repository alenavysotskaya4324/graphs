using System;
using System.Collections.Generic;

namespace AdjacentGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            var reachabilityMatrix = new List<List<int>>();

            Console.WriteLine("Size of matrix:");
            string n = Console.ReadLine();

            Console.WriteLine("Matrix:");

            for (var i = 0; i < Convert.ToInt32(n); i++)
            {
                var elements = Console.ReadLine().Split(' ');
                reachabilityMatrix.Add(new List<int>());
                for (var j = 0; j < Convert.ToInt32(n); j++)
                {
                    reachabilityMatrix[i].Add(int.Parse(elements[j]));
                }
                Console.WriteLine();
            }

            var result = IsItAdjacentGraph(reachabilityMatrix);

            Console.WriteLine(result);
            Console.ReadKey();  
        }

        static bool IsItAdjacentGraph(List<List<int>> matrix)
        {
            for (var i = 0; i < matrix.Count; i++)
            {
                for (var j = 0; j < matrix.Count; j++)
                {
                    if (matrix[i][j] == 1 && matrix[j][i] == 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
