using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2017.Day1
{
    public class Day1Part1 : Puzzle<int>
    {
        public Day1Part1() : base(1)
        {

        }

        public override int Answer(string input)
        {
            var characters = input.ToCharArray();
            var sum = 0;
            for (var i = 0; i < characters.Length; i++)
            {
                var compareTo = i == characters.Length - 1
                    ? 0
                    : i + 1;
                if (characters[i] == characters[compareTo])
                {
                    sum += characters[i] - '0';
                }
            }

            return sum;
        }
    }
}
