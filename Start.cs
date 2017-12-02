using AdventOfCode_2017.Day1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2017
{
    public class Start
    {
        static void Main(string[] args)
        {
            var puzzle = new Day1Part1();
            var input = puzzle.GetInput().GetAwaiter().GetResult();
            var answer = puzzle.Answer(input);
            var y = 10;
        }
    }
}
