using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClassTasks
{
    public class GenericList<T> where T: IComparable, new()
    {
        private readonly int initialCapacity;
        private T[] elements;
        private int count;
        private int capacity;

        public GenericList(int initialCapacity)
        {
            this.InitialCapacity = initialCapacity;
            this.Count = 0;
            this.elements = new T[initialCapacity];
        }
        public T[] Elements { get; set; }
        public int InitialCapacity { get; set; }
        public int Count{ get; private set; }
        public int Capacity { get { return this.elements.Length; } }

        public void AddElement(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.Expand();
            }
            elements[this.Count] = item;
            this.Count++;
        }
        public T AccessByIndex(int ind)
        {
            var result = this.elements[ind];
            return result;
        }

        public void RemoveAtIndex(int index)
        {
            for (var i = index; i < this.Count-1; i++)
            {
                this.elements[i] = this.elements[i + 1];               
            }
            this.elements[this.Count - 1] = default(T);
            this.Count--;         
        }
        public void InsertAt(int index, T element)
        {
            {
                if (index >this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                if (this.Count+1 > this.Capacity)
                {
                    this.Expand();
                }
                var newElements = new T[this.Capacity];
                for (int i = 0; i < index; i++)
                {
                    newElements[i] = this.elements[i];
                }
                newElements[index] = element;
                for (int i = index+1; i < this.Count+1; i++)
                {
                    newElements[i] = this.elements[i-1];
                }
                this.elements = newElements;
            }
        }

        public int FindElementByValue(T element)
        {
            int index = -1;
            for (int i = 0; i < this.Count-1; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Clear()
        {
            this.elements = new T[initialCapacity];            
        }

        public override string ToString()
        {
            return string.Join(" ", this.elements); 
        }
        private void Expand()
        {
            var newElements = new T[2 * this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        public T MinValue()
        {
            return elements.Min();         
        }

        public T MaxValue()
        {
            return elements.Max();
        }

    }
}
