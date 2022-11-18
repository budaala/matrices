using System;

namespace matrix2
{
    internal class ReadAndPrintMatrix
    {
        public string ReadMatrix(string pathToFile)
        {
            return System.IO.File.ReadAllText(pathToFile);
        }
        public Matrix StringMatrixToObject(string matrix)
        {
            string[] rows = matrix.Split('\n');
            string[] allNumbers = matrix.Split(' ', '\n');

            int rowCount = rows.Length;
            int columnCount = allNumbers.Length / rows.Length;

            Matrix newMatrix = new Matrix(rowCount, columnCount);

            int k = 0;

            do
            {
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        newMatrix[i, j] = int.Parse(allNumbers[k]);
                        k++;
                    }
                }
            } while (k < allNumbers.Length);

            return newMatrix;
        }      
    }
    
}
