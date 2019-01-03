using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TreeOfNNodes
{
    public class Tree<T>
    {
        private TreeNode<T> root;
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            this.root = new TreeNode<T>(value);
        }
        public Tree(T value, params Tree<T>[] children):this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }
        public TreeNode<T> Root
        {
            get { return this.root; }
        }
        
        private void TraverseDFS(TreeNode<T> currentNode, string spaces)
        {           
            Console.WriteLine(spaces + currentNode.Value);
           
            for (int i = 0; i < currentNode.ChildernCount; i++)
            {
                TreeNode<T>child = currentNode.GetChild(i);
                TraverseDFS(child, spaces + "   ");
            }
            //postorder
            //Console.WriteLine(spaces + currentNode.Value);
        }
        public void TraverseDFS()
        {
            if (this.root == null)
            {
                return;
            }
            this.TraverseDFS(this.root, string.Empty);
        }

        public void TraverseDFSWithStack()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                TreeNode<T> currentNode = stack.Pop();
                Console.Write("{0}", currentNode.Value);
                for (int i = 0; i < currentNode.ChildernCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    stack.Push(childNode);
                }
            }
        }
        public void TraverseBFS()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                Console.Write("{0}", currentNode.Value);
                for (int i = 0; i < currentNode.ChildernCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    queue.Enqueue(childNode);
                }
            }

        }
    }
}
