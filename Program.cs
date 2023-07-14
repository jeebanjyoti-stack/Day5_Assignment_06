using System;


namespace Day5_Assignment_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][]
        {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
        };
            Console.WriteLine("----------------");
            Console.WriteLine("Student Scores:");
            Console.WriteLine("----------------");

            
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write($"{studentScores[i][j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();



            Console.WriteLine("------------------------------------");
            Console.WriteLine("Average Scores For Each Students:");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = (double)sum / studentScores[i].Length;

                Console.WriteLine($"Student {i + 1}: Average = {average:F2}");
            }

            Console.WriteLine();



            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Average Score For All Students :");
            Console.WriteLine("---------------------------------");

            int totalSum = 0;
            int totalCount = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }

            double overallAverage = (double)totalSum / totalCount;

            Console.WriteLine($"Overall Average = {overallAverage:F2}");

            Console.ReadLine();
        }
    }
}
