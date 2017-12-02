using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2017
{
    public class Start
    {
        static async Task<string> GetPuzzleInput()
        {
            var puzzle = new Puzzle(1);
            var input = await puzzle.GetInput();

            return input;
        }

        static void Main(string[] args)
        {
            var x = Directory.GetCurrentDirectory();
            var result = GetPuzzleInput().GetAwaiter().GetResult();
            Console.WriteLine(result);
            var y = 10;
        }
    }
}
