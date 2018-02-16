using System;
using System.Collections.Generic;
using System.Linq;

namespace MDPyramid
{
    public static class TreeService
    {
        public static IEnumerable<string> FindAllPaths(Node root)
        {
            var queue = new Queue<Tuple<string, Node>>();
            queue.Enqueue(new Tuple<string, Node>(root.Name, root));

            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (node.Item2.Children.Any())
                {
                    foreach (var child in node.Item2.Children)
                    {
                        queue.Enqueue(new Tuple<string, Node>(node.Item1 + "" + child.Name, child));
                    }
                }
                else
                {
                    yield return node.Item1;
                }
            }
        }

        public static Dictionary<int, string> FindNeededPaths(IEnumerable<string> allPaths, bool isEven = false)
        {
            var resultList = new Dictionary<int, string>();
            foreach (var item in allPaths)
            {
                var array = item.Select(x => x - '0').ToArray();
                var tempSum = 0;
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && !isEven)
                    {
                        tempSum += array[i];
                        isEven = true;
                    }
                    else if (array[i] % 2 == 0 && isEven)
                    {
                        tempSum += array[i];
                        isEven = false;
                    }
                    else
                    {
                        break;
                    }
                }
                if (!isEven)
                {
                    resultList.Add(tempSum, item);
                }

                isEven = false;
            }

            return resultList;
        }
    }
}
