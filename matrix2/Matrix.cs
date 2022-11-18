using System;

namespace matrix2
{
    class Matrix
    {
        int _dim0, _dim1;
        int[,] data = new int[5, 5];

        public Matrix(int dim0, int dim1)
        {
            _dim0 = dim0;
            _dim1 = dim1;
        }
        // deklaracja indeksera
        public int this[int x, int y]
        {
            get { return data[x, y]; }
            set { data[x, y] = value; }
        }
        // przeciążanie operatora +
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix addedMatrix = new Matrix(m1._dim0, m1._dim1);

            for (int i = 0; i < m1._dim0; i++)
            {
                for (int j = 0; j < m1._dim1; j++)
                {
                    addedMatrix[i, j] = m1[i, j] + m2[i, j];
                }     
            }
            return addedMatrix;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix multipliedMatrix = new Matrix(m1._dim0, m1._dim1);

            for (int i = 0; i < m1._dim0; i++)
            {
                for (int j = 0; j < m1._dim1; j++)
                {
                    multipliedMatrix[i, j] = m1[i, j] * m2[i, j];
                }
            }
            return multipliedMatrix;
        }
        public Matrix Transpose(Matrix mMatrix)
        {
            Matrix transposed = new Matrix(_dim1, _dim0);

            for (int i = 0; i < _dim1; i++)
            {
                for (int j = 0; j < _dim0; j++)
                {
                    transposed[i, j] = mMatrix[j, i];
                }
            }
            return transposed;
        }
        public void PrintMatrixObj(Matrix mMatrix)
        {
            Console.WriteLine();
            for (int i = 0; i < _dim0; i++)
            {
                for (int j = 0; j < _dim1; j++)
                {
                    Console.Write(mMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}