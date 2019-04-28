using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.FromNet
{
    class BinNode<T> where T:IComparable
    {
        public BinNode<T> right { get; set; }
        public BinNode<T> left { get; set; }
        public T data { get; set; }

        public BinNode(T data)
        {
            this.data = data;
        }
    }
}
