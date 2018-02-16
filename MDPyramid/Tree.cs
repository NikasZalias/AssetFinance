using System.Collections.Generic;

namespace MDPyramid
{
    public static class Tree
    {
        public static Node Root = new Node("1")
        {
            Children = new List<Node>
            {
                new Node("8")
                {
                    Children = new List<Node>
                    {
                        new Node("1")
                        {
                            Children = new List<Node>
                            {
                                new Node("4"), new Node("5")
                            }
                        },
                        new Node("5")
                        {
                            Children = new List<Node>
                            {
                                new Node("5"), new Node("2")
                            }
                        }
                    }
                },
                new Node("9")
                {
                    Children = new List<Node>
                    {
                        new Node("5")
                        {
                            Children = new List<Node>
                            {
                                new Node("5"), new Node("2")
                            }
                        }, new Node("9")
                        {
                            Children = new List<Node>
                            {
                                new Node("2"), new Node("3")
                            }
                        }
                     }
                }
            }
        };
    }
}
