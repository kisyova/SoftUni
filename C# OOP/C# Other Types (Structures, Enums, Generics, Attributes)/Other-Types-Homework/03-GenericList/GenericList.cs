using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{
    [Version(1, 0)]
    public class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int count;

        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
            this.Count = count;
        }

        public int Count {
            get { return this.count; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                this.count = value;

                if (count >= this.Capacity)
                {
                    this.DoubleArray();
                }
            }
        }

        public int Capacity {
            get { return this.elements.Length; }
           
           }

        public T this[int index]{
            get
            {
                if (index < 0 || index >= this.count)
                    throw new IndexOutOfRangeException();
                return elements[index];
            }
        }

        public void AddElement(T element) {
            if (this.count >= this.elements.Length)
            {
                this.DoubleArray();
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public void RemoveElement(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < this.count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.count--;
            this.elements[count] = default(T);
        }

        public void InsertElement(uint index, T element)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            if (this.count == this.elements.Length)
            {
                this.DoubleArray();
            }
            for (int i = count; i < index; i++)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.count--;
            this.elements[count] = element;
        }

        public void ClearList()
        {
            this.elements = new T[this.elements.Length];
            this.count = 0;
        }

        public int FindElement(T value)
        {
            int index = -1;
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public bool Cointains(T value)
        {
            return this.FindElement(value) == -1 ? false : true;
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The generic list is empty!");
            }

            T min = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }

            return min;

        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The generic list is empty!");
            }

            T max = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public void DoubleArray()
        {
            T[] doubleArray = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                doubleArray[i] = this.elements[i];
            }
            this.elements = doubleArray;
        }

        public override string ToString()
        {
            if (this.count == 0)
            {
                return "The generic list is empty!";
            }
            
            StringBuilder list = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                list.AppendLine(String.Format("{0}: {1}", i, this.elements[i]));
            }
            return list.ToString();
        }
    }
}
