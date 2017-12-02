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
            var characters = input.Trim().ToCharArray();
            var count = 0;
            for (var i = 0; i < characters.Length; i++)
            {
                var compareTo = i == characters.Length - 1
                    ? 0
                    : i + 1;
                if (characters[i] == characters[compareTo])
                {
                    Console.WriteLine($"Characters[{i}]={characters[i]} - Characters[{compareTo}]={characters[compareTo]}");
                    var toAdd = characters[i] - '0';
                    count += toAdd;
                    Console.WriteLine(toAdd);
                }

                if (i == characters.Length - 1)
                {
                    var x = 10;
                }
            }

            return count;
        }
    }
}
