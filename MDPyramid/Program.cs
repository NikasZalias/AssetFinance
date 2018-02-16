using System;
using System.Linq;

namespace MDPyramid
{
    class Program
    {
        public static void Main()
        {           
            var bfsPaths = TreeService.FindAllPaths(Tree.Root);
            var neededPaths = TreeService.FindNeededPaths(bfsPaths);

            var maxSum = neededPaths.Keys.Max();

            Console.WriteLine("Max sum: " + maxSum);
            Console.WriteLine("Path: " + neededPaths[maxSum]);

            Console.ReadKey();
        }
    }
}
