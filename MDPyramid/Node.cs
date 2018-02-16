using System.Collections.Generic;

namespace MDPyramid
{
    public class Node
    {
        public string Name { get; set; }

        public List<Node> Children { get; set; }

        public Node(string name)
        {
            Name = name;
            Children = new List<Node>();
        }
    }
}
