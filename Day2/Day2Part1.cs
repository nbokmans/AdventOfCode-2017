using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode_2017.Day2
{
    public class Day2Part1 : Puzzle<int>
    {
        public Day2Part1() : base(2)
        {
        }

        public override int Answer(string input)
        {
            input = input.Replace('\t', ' ').Trim();
            var lines = input.Split('\n');
            var x = lines.Length;
            var sum = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(" ").Select(num => int.Parse(num));
                var min = numbers.Min();
                var max = numbers.Max();
                var diff = max - min;
                sum += diff;
            }
            return sum;
        }
    }
}
