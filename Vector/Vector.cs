using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private double[] values;

        public Vector(int size = 0)
        {
            values = new double[size];
        }

        public Vector(double[] values)
        {
            this.values = values;
        }

        public void Append(double newValue)
        {
            double[] newValues = new double[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                newValues[i] = values[i];
            }
            newValues[newValues.Length - 1] = newValue;
            values = newValues;
        }

        public int Size
        {
            get
            {
                return values.Length;
            }
        }

        public double GetElementAt(int index)
        {
            if (index < 0 || index >= values.Length)
            {
                throw new IndexOutOfRangeException("Index is out of vector's range");
            }
            return values[index];
        }

        public void SetElementAt(int index, double newValue)
        {
            if (index < 0 || index >= values.Length)
            {
                throw new IndexOutOfRangeException("Index is out of vector's range");
            }
            values[index] = newValue;
        }

        public Vector Add(Vector other)
        {
            if (values.Length != other.Size)
            {
                throw new Exception("Vectors have different sizes");
            }
            Vector resultVector = new Vector(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.SetElementAt(i, values[i] + other.GetElementAt(i));
            }
            return resultVector;
        }
        public Vector Subtract(Vector other)
        {
            if (values.Length != other.Size)
            {
                throw new Exception("Vectors have different sizes");
            }
            Vector resultVector = new Vector(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.SetElementAt(i, values[i] - other.GetElementAt(i));
            }
            return resultVector;
        }
  
        public Vector Multiply(double scalarValue)
        {
            Vector resultVector = new Vector(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.SetElementAt(i, values[i]* scalarValue);
            }
            return resultVector;
        }
        public Vector Divide(double scalarValue)
        {
            Vector resultVector = new Vector(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.SetElementAt(i, values[i] / scalarValue);
            }
            return resultVector;
        }
   
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Vector elements are: ");
            for (int i = 0; i < values.Length; i++)
            {
                if (i != 0) sb.Append("; ");
                sb.Append(values[i]);
            }
            return sb.ToString();
        }
        public void print()
        {
            Console.WriteLine(this);
        }
        public void print(int index) 
        {
            Console.WriteLine($"{index} элемент: {this.GetElementAt(index)}");
        }
            
    }
}
