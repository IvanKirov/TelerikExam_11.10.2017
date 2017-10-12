The 3 tasks from the Telerik exam on 11.10.2017


Task 1 - Crooked Digits
The crooked digit of a given number N is calculated using the number's digits in a very weird and bendy algorithm. The algorithm takes the following steps:
1.	Sums the digits of the number N and stores the result back in N.
2.	If the obtained result is bigger than 9, step 1. is repeated, otherwise the algorithm finishes.
The last obtained value of N is the result, calculated by the algorithm.
Input
•	The input data should be read from the console.
•	The only line in the input contains a number N, which can be integer or real number (decimal fraction), positive or negative.
•	The input data will always be valid and in the format described. There is no need to check it explicitly
Output
•	The output data should be printed on the console.
•	You must print the calculated crooked digit of the number N on the first and only line of the output.
Constraints
•	The number N will have no more than 300 digits before and after the decimal point.
•	The decimal separator will always be the "." symbol.


Task 2 - Crooked Stairs
You need to design the staircases for the first skyscraper in Sofia. But not just any ordinary stairs - in order to keep the people awake while using them, each brick you place must have a different height, even if that violates the laws of physics.
A staircase is a sequence of bricks, ordered in a shape, similar to a triangle. Each brick triangle is being build in layers from the top to the bottom (as we said, we don't care about physics).
The first layer of the brick triangle contains only the first brick of the sequence. The second layer contains the second and third bricks and so on. A brick triangle of 3 layers would look something like this:
 Brick1
Brick2 Brick3
Brick4 Brick5 Brick6 
The sequence of bricks begins with three integers (the brick heights), that can be either positive or negative. The height of each brick, after the third one, is calculated by the sum of the last three bricks, using the formula -> Bhn = Bhn-1 + Bhn-2 + Bhn-3, where Bh is the brick height.
So if Brick1 has a height of 2, Brick2 of 1 and Brick3 of 5, the triangle would look like this:
 2
1 5
8 14 27 
•	Brick4's height is calculated by Bh4 = Bh4-1 + Bh4-2 + Bh4-3 which results to Bh4 = 2 + 1 + 5 = 8
•	Brick5's height is calculated by Bh5 = Bh5-1 + Bh5-2 + Bh5-3 which results to Bh5 = 1 + 5 + 8 = 14
•	Brick6's height is calculated by Bh6 = Bh6-1 + Bh6-2 + Bh6-3 which results to Bh6 = 5 + 8 + 14 = 27
Input
•	The first three lines will contain the heigths of the first three bricks of the brick sequence.
•	On the fourth line of the input there will be the number L – the number of layers in the brick triangle.
Output
•	The output should contain exactly L amount of lines.
•	The first line should consist of exactly 1 number.
•	The second line should consist of exactly 2 numbers, separated by a space (" ").
•	The third line should consist of exactly 3 numbers, separated by a space (" ").
•	And so on...
Constraints
•	The number of lines is in the range [2..20] inclusive.

Task 3 - Crooked Walls
Now that you have successfully built the staircases, you need to design the walls for the first skyscraper in Sofia. And again, in order to make the building look more fancy and disobay the 'walls' of physics, each wall will have a different height.
The walls are a sequence of N-amount of integers that represent each wall's height, that can be either positive or negative. That sequence will be given to you in the input. You need to use it in order to calculate the space between each of the walls.
For example, you are given the sequence 2 7 4 12 6 4 4. In order to calculate the distance between each of the walls, you need to find the absolute difference between their heights.
Absolute difference between two integer numbers A and B is the difference of the larger between A and B minus the smaller between A and B. Examples:
•	Absolute difference between 6 and 2 is 4 (6 – 2 = 4).
•	Absolute difference between -4 and 4 is 8 (-4 – 4 = 8).
Knowing that, our example becomes: 25734812662404. Now, that seems a bit too complicated, no? Lets make it easier. Instead of finding each distance between the walls, we will do some hopping around. Let me give you a hint so it's even easier. Start from the second wall's height. Then find the distance between the current wall and the previous wall.
•	If the distance is an odd number, move one positions to the right.
•	If the distance is an even number, move two positions to the right.
Knowing that, our example becomes: 25734812skipped624skipped4, which results in 25734812062404. Now, to make things even more simple, we need to find the sum of the even distances between the walls. In this example, the only even ones are between the walls with height 4 and 12 and the walls with heigth 6 and 4. That means that we need to sum 8 + 2. Therefore, we output 10 on the console.
Input
•	The sequence will be given on the only input line. All numbers will be separated by a single space (‘ ‘).
Output
•	On the only output line write the sum of all even distances between walls, found during the execution of your program.
Constraints
•	There will be between 2 and 200 numbers in the input, inclusive.
•	Each number will be between -2 000 000 000 and +2 000 000 000.

