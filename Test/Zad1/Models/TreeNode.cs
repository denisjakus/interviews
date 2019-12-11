using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1.Models
{public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();
    }
}
