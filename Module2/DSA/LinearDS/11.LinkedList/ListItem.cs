using System;
using System.Collections.Generic;
using System.Text;

namespace _11.LinkedList
{
    public class ListItem<T>
    {
        private readonly T value;
        private readonly ListItem<T> next;

        public ListItem(T value, ListItem<T> next=null)
        {
            this.Value = value;
            this.Next = next;
        }

        public T Value { get; set; }
        public ListItem<T> Next { get; set; }
    }
}
