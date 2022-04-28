using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Matrix
    {
        private int N;
        private int[,] matrix;
        public Matrix()
        {
            this.N = 0;
            this.matrix = new int[N, N];
        }
        public Matrix(int n)
        {
            if (n > 0)
            {
                this.N = n;

                this.matrix = new int[N, N];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = 0; 
                    }
                }
            }
        }
        public static Matrix Create()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Please, input number of lines|rows:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(n > 0));
            return new Matrix(n);
        }
        public void Fill()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)

                {
                    Console.WriteLine("Input number in line {0} in row {1}", i + 1, j + 1);
                    this.matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                { 
                    Console.Write("{0} ", matrix[i, j]); 
                }
                Console.WriteLine();
            }
        }
        public static Matrix operator + (Matrix a, Matrix b)
        {
            if (a.N == b.N)
            {
                var matrix = new Matrix(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    { 
                        matrix.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j]; 
                    }
                }
                return matrix;
            }
            else
            {
                Console.WriteLine("Matrix must have same size! Returning zero matrix...");
                return new Matrix();
            }
        }
        public static bool operator == (Matrix a, Matrix b)
        {
            if (a.N == b.N && a.N == b.N)
            {
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        if (a.matrix[i, j] != b.matrix[i, j])
                        { 
                            return false; 
                        }

                    }
                }
                return true;
            }
            else
            { 
                return false; 
            }
        }
        public static bool operator != (Matrix a, Matrix b)
        {
            if (a.N == b.N)
            {
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        if (a.matrix[i, j] != b.matrix[i, j])
                        { 
                            return true; 
                        }
                    }
                }
                return false;
            }
            else
            { 
                return true; 
            }

        }
        public double Norm()
        {
            double min = matrix[0, 0];
            double max = matrix[0, 0];
            double result = 0;

            for (int i = 0; i < N; i++)
            { 
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }

                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            result = Math.Abs(max - min);
            return result;
        }
    }
}