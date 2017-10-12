using System;
using System.Collections.Generic;

namespace Task_2
{
    public class CrookedStairs
    {
        public static void Main()
        {
            var hightFirstBrick = int.Parse(Console.ReadLine());
            var hightSecondBrick = int.Parse(Console.ReadLine());
            var hightThirdBrick = int.Parse(Console.ReadLine());
            var numberOfLayers = int.Parse(Console.ReadLine());

            PrintOutput(hightFirstBrick, hightSecondBrick, hightThirdBrick, numberOfLayers);
        }

        private static void PrintOutput(int hightFirstBrick, int hightSecondBrick, int hightThirdBrick, int numberOfLayers)
        {
            Console.WriteLine(hightFirstBrick);
            Console.WriteLine(hightSecondBrick + " " + hightThirdBrick);

            if (numberOfLayers > 2)
            {
                Queue<int> oldBricks = new Queue<int>(new[] { hightFirstBrick, hightSecondBrick, hightThirdBrick });
                List<int> bricks = new List<int>();

                for (int layer = 2; layer < numberOfLayers; layer++)
                {                   
                    for (int layerOfBricks = 0; layerOfBricks <= layer; layerOfBricks++)
                    {
                        var newBrick = 0;

                        foreach (var brick in oldBricks)    
                        {
                            newBrick += brick;
                        }
                        oldBricks.Dequeue();
                        oldBricks.Enqueue(newBrick);
                        bricks.Add(newBrick);
                    }

                    Console.WriteLine(string.Join(" ", bricks));
                    bricks.Clear();
                }
            }
        }
    }
}
