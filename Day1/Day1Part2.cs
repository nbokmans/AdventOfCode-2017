using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode_2017.Day1
{
    public class Day1Part2 : Puzzle<int>
    {
        public Day1Part2() : base(1)
        {
        }

        public override int Answer(string input)
        {
            var characters = input.ToCharArray();
            var sum = 0;
            var halfwayAround = characters.Length / 2;
            for (var i = 0; i < characters.Length; i++)
            {
                var compareTo = i + halfwayAround;

                if (compareTo > characters.Length)
                {
                    compareTo = halfwayAround - (characters.Length - i);
                }

                if (compareTo == characters.Length)
                {
                    compareTo = 0;
                }

                Console.WriteLine($"Characters[{i}]={characters[i]} - Characters[{compareTo}]={characters[compareTo]}");

                if (characters[i] == characters[compareTo])
                {
                    sum += characters[i] - '0';
                }
            }

            return sum;
        }
    }
}
