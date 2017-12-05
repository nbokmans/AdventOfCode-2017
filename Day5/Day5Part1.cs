using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode_2017.Day5
{
    public class Day5Part1 : Puzzle<int>
    {
        public Day5Part1() : base(5)
        {
        }

        public override int Answer(string input)
        {

            var instructions = input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            var index = 0;
            var count = 0;
            while (index >= 0 && index < instructions.Length)
            {
                count++;
                var instruction = instructions[index];
                instructions[index] += 1;
                index += instruction;
            }

            return count;
        }
    }
}
