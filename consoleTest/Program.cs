using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Threading.Tasks;

namespace consoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string n = Console.ReadLine();
            //Console.WriteLine("Welcome " + n);
            //Console.Write(System.IO.Directory.GetCurrentDirectory());
            //string[] tmpstr = { System.IO.Directory.GetCurrentDirectory(), "\\" };
            //TextWriter textWriter = new StreamWriter(String.Join("", tmpstr), true);

            int n = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int lr = 0;
            int rl = 0;
            int retval = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        lr = lr + arr[i][j];
                    }
                }
                for (int j = arr.GetLength(1); j >= 0; j--)
                {
                    if (0 + j == arr.GetLength(1))
                    {
                        rl = rl + arr[i][j];
                    }
                }
            }

            lr = arr[0][0] + arr[1][1] + arr[2][2];
            rl = arr[2][0] + arr[1][1] + arr[0][2];

            retval = Math.Abs(lr - rl);
            return retval;
        }
    }
}
