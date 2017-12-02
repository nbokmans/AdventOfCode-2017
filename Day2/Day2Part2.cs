using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode_2017.Day2
{
    public class Day2Part2 : Puzzle<int>
    {
        public Day2Part2() : base(2)
        {
        }

        public override int Answer(string input)
        {
            input = input.Replace('\t', ' ').Trim();
            var lines = input.Split('\n');
            var sum = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(" ").Select(num => int.Parse(num));
                var pairs = numbers.SelectMany(n => numbers, (n1, n2) => Tuple.Create(n1, n2)).Where(p => p.Item1 != p.Item2);
                var evenlyDivisble = pairs.Where(p => ((double)p.Item1 / p.Item2) % 1 == 0);
                sum += evenlyDivisble.Sum(p => (p.Item1 / p.Item2));
            }
            return sum;
        }
    }
}
