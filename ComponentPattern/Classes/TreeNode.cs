using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentPattern.Classes
{
    /// <summary>
    /// Generic tree node class
    /// </summary>
    /// <typeparam name="T">Node type</typeparam>
    class TreeNode<T> where T : IComparable<T>
    {
        List<TreeNode<T>> children = new List<TreeNode<T>>();

        // Add a child tree node
        public TreeNode<T> Add(T child)
        {
            var newNode = new TreeNode<T> { Node = child };
            children.Add(newNode);
            return newNode;
        }

        // Remove a child tree node
        public void Remove(T child)
        {
            foreach (var treeNode in children)
            {
                if (treeNode.Node.CompareTo(child) == 0)
                {
                    children.Remove(treeNode);
                    return;
                }
            }
        }

        // Gets or sets the node
        public T Node { get; set; }

        // Gets treenode children
        public List<TreeNode<T>> Children
        {
            get { return children; }
        }

        // Recursively displays node and its children 
        public static void Display(TreeNode<T> node, int indentation)
        {
            string line = new String('-', indentation);
            Console.WriteLine(line + " " + node.Node);

            node.Children.ForEach(n => Display(n, indentation + 1));
        }
    }
}
