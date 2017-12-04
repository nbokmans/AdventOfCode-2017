using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode_2017.Day4
{
    public class Day4Part2 : Puzzle<int>
    {
        public Day4Part2() : base(4)
        {
        }

        public override int Answer(string input)
        {
            var passphrases = input.Split('\n').Select(l => l.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries));
            return passphrases.Select(pp => pp
                .GroupBy(w => string.Concat(w.OrderBy(c => c))) //Group by sorted characters
                .Any(g => g.Count() > 1) ? 0 : 1) //if duplicate groups, don't count as valid passphrase
                .Sum();
        }
    }
}