using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _11.LinkedList
{
    public class LinkedList<T>:IEnumerable<T>
    {
        private readonly ListItem<T> firstElement;
       
        public LinkedList()
        {
            this.FirstElement = null;
        }

        public ListItem<T> FirstElement { get; set; }

        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newItem = new ListItem<T>(value);
                newItem.Next = this.FirstElement;
                this.FirstElement = newItem;
            }
        }
        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newItem = this.FirstElement;
                while (newItem.Next != null)
                {
                    newItem = newItem.Next;
                }

                newItem.Next = new ListItem<T>(value);
            }
        }

        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.Next;
        }

        public void RemoveLast()
        {
            ListItem<T> newItem = this.FirstElement;
            while (newItem.Next!= null)
            {
                newItem = newItem.Next;
            }

            newItem.Next = null;
        }

        public int Count()
        {
            int counter = 1;
            ListItem<T> newItem = this.FirstElement;

            while (newItem.Next != null)
            {
                newItem = newItem.Next;
                counter++;
            }

            return counter;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListItem<T> newItem = this.FirstElement;
            while (newItem != null)
            {
                yield return newItem.Value;
                newItem = newItem.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();           
        }
    }
}
