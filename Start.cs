using AdventOfCode_2017.Day1;
using AdventOfCode_2017.Day2;
using AdventOfCode_2017.Day3;
using AdventOfCode_2017.Day4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2017
{
    public class Start
    {
        static void Main(string[] args)
        {
            var puzzle = new Day4Part2();
            var input = puzzle.GetInput().GetAwaiter().GetResult();
            var answer = puzzle.Answer(input);
            var y = 10;
        }
    }
}
