using System;
using System.Collections.Generic;
using System.Linq;
using Zad1.Extensions;
using Zad1.Models;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0) return;

            var indexList = args.ConvertArrayOfStringsToListOfIntegers();

            var unLinkedTreeNodes = new List<TreeNode<int>>();

            for (var i = 0; i < indexList.Count; i++)
            {
                unLinkedTreeNodes.Add(new TreeNode<int>() { Data = i });
            }

            TreeNode<int> rootNode = null;
            var linkedTreeNodes = new List<TreeNode<int>>();

            linkedTreeNodes = unLinkedTreeNodes;

            for (var index = 0; index < indexList.Count; index++)
            {
                var nodeName = indexList[index];

                var isRootNode = (nodeName == -1);

                if (isRootNode)
                {
                    var parent = unLinkedTreeNodes[index];
                    rootNode = parent;
                }
                else
                {
                    var unlinkedNode = unLinkedTreeNodes[index];
                    unlinkedNode.Parent = linkedTreeNodes.FirstOrDefault(n => n.Data == nodeName);

                    linkedTreeNodes.FirstOrDefault(n => n.Data == nodeName)?.Children.Add(unlinkedNode);
                }
            }

            var treeHeight = rootNode.TreeHeight(0);
            var leafCount = rootNode.LeafCount(root => root.Children);

            Console.WriteLine($"Tree height: {treeHeight}");
            Console.WriteLine($"Tree number of leaves: {leafCount}");

            Console.ReadLine();
        }
    }
}
