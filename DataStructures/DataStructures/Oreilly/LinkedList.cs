using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Oreilly
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public T Value { get; set; }
    }

    public class LinkedList<T>
    {
        public Node<T> Root { get; private set; }

        public (Node<T> previous, Node<T> found) FindFirst(T value)
        {
            Node<T> previous = null;
            Node<T> current = Root;

            if (null == current) return (null,null);            
            if (current.Value.Equals(value)) return (null,Root);

            do
            {
                previous = current;
                current = current.Next;

                if (current.Value.Equals(value))
                    return (previous, current);
                
            } while (null != current.Next);

            return (null,null);            
        }

        public Node<T> AddAfter(Node<T> node, T value)
        {
            var valueNode = new Node<T>
            {
                Next = node.Next,
                Value = value
            };

            node.Next = valueNode;
            return valueNode;        
        }

        public Node<T> Add(T value)
        {
            var valueNode = new Node<T> {
                Value = value,
                Next = null
        };

            if (null == Root) Root = valueNode;

            else
            {
                var node = Root;
                while (null !=node.Next)
                {
                    node = node.Next;
                }
                node.Next = valueNode;
            }
            return valueNode;
        }

        public bool DeleteAfter(Node<T> node)
        {
            var nextNode = node.Next;
            if (null == nextNode) return false;

            node.Next = nextNode.Next;
            return true;
            
        }
    }
}
