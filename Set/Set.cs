using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    class MySet
    {
        #region fields
        private string[] elements;
        #endregion

        #region constructors
        public MySet()
        {
            elements = new string[0];
        }
        public MySet(int size)
        {
            elements = new string[size];
        }

        public MySet(string[] elements)
        {

            this.elements = RemoveEqualElemens(elements);
        }
        #endregion

        #region properties
        public int Size
        {
            get
            {
                return elements.Length;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                    return $"Некорректный ввод индекса";
                return GetElementAt(index);
            }
            set
            {
                if (index < 0 || index >= Size)
                    throw new ArgumentOutOfRangeException();
                SetElementAt(index, value);
            }
        }
        #endregion
        #region private methods
        private string[] RemoveEqualElemens(string[] elements) 
        {
            int len = elements.Length;
            string[] noEqualElements = new string[0];
            for (int i = 0; i < len - 1; i++)
            {
                if (Array.IndexOf(elements, elements[i], i + 1) == -1)
                {
                    string[] newNoEqualElements = new string[noEqualElements.Length + 1];

                    for (int j = 0; j < noEqualElements.Length; j++)
                    {
                        newNoEqualElements[j] = noEqualElements[j];
                    }
                    newNoEqualElements[newNoEqualElements.Length - 1] = elements[i];
                    noEqualElements = newNoEqualElements;
                }
               
            }
            if (Array.IndexOf(elements, elements[len - 1], 0, len - 2) == -1)
            {
                string[] newNoEqualElements = new string[noEqualElements.Length + 1];

                for (int j = 0; j < noEqualElements.Length; j++)
                {
                    newNoEqualElements[j] = noEqualElements[j];
                }
                newNoEqualElements[newNoEqualElements.Length - 1] = elements[len-1];
                noEqualElements = newNoEqualElements;
            }
            return noEqualElements;
        }
        #endregion

        #region public methods
        #region methods for getting and setting elements
        public string GetElementAt(int index)
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException("Index is out of set's range");
            }
            Random rnd = new Random();
            int i  = rnd.Next(elements.Length);
            return elements[i];
        }

        public void SetElementAt(int index, string newElement)
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException("Index is out of vector's range");
            }
            Random rnd = new Random();
            int i = rnd.Next(elements.Length);
            elements[i] = newElement;
        }
        #endregion
        #region oter public methods
        public void Add(string newElement)//Добавление элемента
        {
            if (Array.IndexOf(elements, newElement) == -1)
            {
                string[] newElements = new string[elements.Length + 1];

                for (int i = 0; i < elements.Length; i++)
                {
                    newElements[i] = elements[i];
                }
                newElements[newElements.Length - 1] = newElement;
                elements = newElements;
            }
        }
        public void Remove(string removeElement)//Удаление элемента
        {
            int index = Array.IndexOf(elements, removeElement);
            if (index != -1)
            {
                string[] remElements = new string[elements.Length - 1];

                for (int i = 0; i < index; i++)
                {        
                    remElements[i] = elements[i];
                }
                for (int i = index; i < elements.Length - 1;i++)
                {
                    remElements[i] = elements[i + 1];
                }
                elements = remElements;
            }
        }

        public int SubSet(MySet otherSet)
        {
            foreach (string element in otherSet.elements)
            {
                if (Array.IndexOf(this.elements, element) == -1)
                {
                    return 1;//$"Множество не являетя подмножеством";
                }
            }
            return 0; //$"Множество являетя подмножеством";
        }

        public override string ToString()
        {
            Random rnd = new Random();
            int len = elements.Length;
            for (int i = 0; i <len; i++)
            {
                int j = rnd.Next(len);
                var temp = elements[j];
                elements[j] = elements[i];
                elements[i] = temp;
            }
            StringBuilder sb = new StringBuilder("Set elements are: ");
            for (int i = 0; i < len; i++)
            {
                if (i != 0) sb.Append("; ");
                sb.Append(elements[i]);
            }
            return sb.ToString();
        }
        #endregion
        #region methods for overloading operators
        public MySet Union(MySet otherSet)
        {
            MySet unionSets =new MySet(this.elements);
            foreach (string element in otherSet.elements)
            {
                if (Array.IndexOf(this.elements, element) == -1) 
                {
                    unionSets.Add(element);
                }             
            }
            return unionSets;
        }

        public MySet Intersection(MySet otherSet)
        {
            MySet intersectionSets = new MySet();
            foreach (string element in otherSet.elements)
            {
                if (Array.IndexOf(this.elements, element) != -1)
                {
                    intersectionSets.Add(element);
                }           
            }
            return intersectionSets;
        }


      
        public MySet Difference(MySet otherSet)
        {
            MySet differenceSets = new MySet();
            foreach (string element in this.elements)
            {
                if (Array.IndexOf(otherSet.elements, element) == -1)
                {
                    differenceSets.Add(element);
                }
            }
            return differenceSets;
        }

        #endregion
        #endregion

        #region operators
        public static MySet operator +(MySet a, MySet b)
        {
            return a.Union(b);
        }

   
        public static MySet operator *(MySet a, MySet b)
        {
            return a.Intersection(b);
        }

        public static MySet operator -(MySet a, MySet b)
        {
            return a.Difference(b);
        }
        #endregion
    }
}
