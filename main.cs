using System;

namespace dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrix = new int[5,5];
            for(int i=0; i<5; i++){
                for(int j=0; j<5; j++){
                    matrix[i, j] = rnd.Next(0,20);
                }
            }
        }
    }
}
