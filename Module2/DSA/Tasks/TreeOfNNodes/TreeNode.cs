﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfNNodes
{
    public class TreeNode<T>
    {
        private T value;
        private bool hasParent;
        private List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            this.value = value;
            this.children = new List<TreeNode<T>>();         
        }
        public T Value { get; set; }
        public int ChildernCount
        {
            get
            {
                return this.children.Count;
            }
        }
        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException();
            }
            if (child.hasParent)
            {
                throw new ArgumentException();
            }
            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
      
    }
}
