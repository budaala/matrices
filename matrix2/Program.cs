using System;
/*
2. Tworzymy klasę Matrix, która musi pobrać macierz z pliku i pozwolić na jej transpozycje, dodanie dwóch macierzy, mnożenie dwóch macierzy (dwa ostatnie wymagają przeciążenia operatorów).
 */
namespace matrix2
{
    internal class Program
    {
        static void Main()
        {
            var r = new ReadAndPrintMatrix();

            // pliki z matrycami do zmiennej typu string
            string s1 = r.ReadMatrix(@"C:\Users\budaa\Dokumenty\VS\matrix.txt");
            string s2 = r.ReadMatrix(@"C:\Users\budaa\Dokumenty\VS\matrix2.txt");

            Matrix matrix1 = r.StringMatrixToObject(s1);
            Matrix matrix2 = r.StringMatrixToObject(s2);

            Matrix transposed = matrix1.Transpose(matrix1);
            Matrix added = matrix1 + matrix2;
            Matrix multiplied = matrix1 * matrix2;

            // wyświetlanie matryc
            Console.WriteLine("Pierwsza macierz: ");
            matrix1.PrintMatrixObj(matrix1);

            Console.WriteLine("Pierwsza macierz po transpozycji: ");
            transposed.PrintMatrixObj(transposed);

            Console.WriteLine("Druga macierz: ");
            matrix2.PrintMatrixObj(matrix2);

            Console.WriteLine("Pierwsza i druga macierz dodane ze sobą: ");
            added.PrintMatrixObj(added);

            Console.WriteLine("Pierwsza i druga macierz pomnożone przez siebie: ");
            multiplied.PrintMatrixObj(multiplied);

            Console.WriteLine("\nPress any key to exit....");
            Console.ReadLine();
        }
    }
}
