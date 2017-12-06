using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode_2017.Day6
{
    public class Day6Part1 : Puzzle<int>
    {
        public Day6Part1() : base(6)
        {
        }

        public override int Answer(string input)
        {
            var memoryBlocks = input.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
            var configurations = new List<int[]>();

            while (!configurations.Any(c => c.SequenceEqual(memoryBlocks)))
            {
                configurations.Add(memoryBlocks.ToArray());
                var highestIndex = Array.IndexOf(memoryBlocks, memoryBlocks.Max());

                var memoryBlock = memoryBlocks[highestIndex];
                memoryBlocks[highestIndex++] = 0;

                while (memoryBlock > 0)
                {
                    highestIndex = highestIndex % memoryBlocks.Length;

                    memoryBlocks[highestIndex++] += 1;
                    memoryBlock--;
                }
            }

            return configurations.Count();
        }
    }
}
