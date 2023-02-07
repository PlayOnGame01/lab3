using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_03._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //int[][,] MixArray = new int[4][,];
            //Random r = new Random();
            //for (int i = 0; i < MixArray.Length; i++)
            //{
            //    MixArray[i] = new int[1, r.Next(2, 6)];
            //}
            //int min = MixArray[0].Length, max = 0, min_index = 0, max_index = 0;
            //for (int i = 0; i < MixArray.Length; i++)
            //{
            //    for (int j = 0; j < MixArray[i].GetLength(0); j++)
            //    {
            //        for (int t = 0; t < MixArray[i].GetLength(1); t++)
            //        {
            //            MixArray[i][j, t] = r.Next(1, 20);
            //            Console.Write(MixArray[i][j, t] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    if (min > MixArray[i].Length) { min = MixArray[i].Length; min_index = i; }
            //    if (max < MixArray[i].Length) { max = MixArray[i].Length; max_index = i; }
            //}
            //Console.WriteLine($"\nmax = {max} \tindex = {max_index}");
            //Console.WriteLine($"min = {min} \tindex = {min_index}");
            //int[][,] arr = new int[1][,];
            //arr[0] = MixArray[min_index];
            //MixArray[min_index] = MixArray[max_index];
            //MixArray[max_index] = arr[0];

            //Console.WriteLine("\n");
            //for (int i = 0; i < MixArray.Length; i++)
            //{
            //    for (int j = 0; j < MixArray[i].GetLength(0); j++)
            //    {
            //        for (int t = 0; t < MixArray[i].GetLength(1); t++)
            //        {
            //            Console.Write(MixArray[i][j, t] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region ex2
            //int[][] mas = new int[8][];
            //for (int i = mas.Length; i > 0; i--)
            //{
            //    mas[i - 1] = new int[i - 1];
            //    for (int j = mas[i - 1].Length; j > 0; j--)
            //    {
            //        Console.Write(mas[i - 1][j - 1] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}