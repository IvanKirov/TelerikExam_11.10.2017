using System;
using System.Linq;

namespace Task_3
{
    public class Crooked_Walls
    {
        public static void Main()
        {
            var wallsHeights = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            long answer = 0;

            for (int i = 1; i < wallsHeights.Length; i++)
            {
                var currentWallHeight = wallsHeights[i];
                var previousWallHeight = wallsHeights[i - 1];
                var highWall = Math.Max(currentWallHeight, previousWallHeight);
                var lowWall = Math.Min(currentWallHeight, previousWallHeight);
                var distance = highWall - lowWall;

                if (distance % 2 == 0)
                {
                    answer += distance;
                    i++;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
