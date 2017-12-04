using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode_2017.Day4
{
    public class Day4Part1 : Puzzle<int>
    {
        public Day4Part1() : base(4)
        {
        }

        public override int Answer(string input)
        {
            var passphrases = input.Split('\n').Select(pp => pp.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            return passphrases.Where(pp => pp.Length == pp.Distinct().Count()).Count();
        }
    }
}
