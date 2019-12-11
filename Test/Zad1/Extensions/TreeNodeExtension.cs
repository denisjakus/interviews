using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zad1.Models;

namespace Zad1.Extensions
{
    public static class TreeNodeExtension
    {
        public static int TreeHeight<T>(this TreeNode<T> root, int depth)
        {
            var result = depth;

            foreach (var node in root.Children)
            {
                result = Math.Max(result, TreeHeight(node, depth + 1));
            }

            return result;
        }

        public static int LeafCount<T>(this T rootNode, Func<T, IEnumerable<T>> childrenF)
        {

            return EnumerateLeaves(rootNode, childrenF).ToList().Count;
        }

        private static IEnumerable<T> EnumerateLeaves<T>(this T rootNode, Func<T, IEnumerable<T>> childrenF)
        {
            var children = childrenF(rootNode);

            var hasChildren = children != null && children.Any();

            if (!hasChildren)
            {
                yield return rootNode;
            }
            else
            {
                foreach (var node in childrenF(rootNode))
                {
                    foreach (var child in EnumerateLeaves(node, childrenF))
                    {
                        children = childrenF(child);
                        hasChildren = childrenF(child) != null && children.Any();
                        if (!hasChildren)
                        {
                            yield return child;
                        }
                    }
                }
            }
        }
    }
}
