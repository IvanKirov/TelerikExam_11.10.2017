using System;

namespace Task_1
{
    public class CrookedDigits
    {
        public static void Main()
        {
            var inputN = Console.ReadLine();
            var answer = 0;

            while (inputN.Length > 1)
            {                
                for (int i = 0; i < inputN.Length; i++)
                {
                    var newDigit = inputN[i];
                    if (newDigit == '.' || newDigit == '-') { }
                    else
                    {
                        answer += (newDigit - 48);
                    }
                }
                inputN = answer.ToString();
                answer = 0;
            }

            if (answer == 0)
            {
                answer = int.Parse(inputN);
            }

            Console.WriteLine(answer);
        }
    }
}
