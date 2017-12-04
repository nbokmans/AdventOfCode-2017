using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode_2017.Day3
{
    public class Day3Part1 : Puzzle<int>
    {
        public Day3Part1() : base(3)
        {
        }

        public override int Answer(string input)
        {
            var number = int.Parse(input);
            return CalculateNumSteps(number);
        }

        public int CalculateNumSteps(int square)
        {
            if (square == 1) return 0;

            var ringAndGridsize = RingAndGridSize(square);
            var ring = ringAndGridsize.Item1;
            var gridSize = ringAndGridsize.Item2;

            var minNumInRing = (gridSize * gridSize) - ((gridSize - 1) * (gridSize - 1)) + 1;
            var maxNumInRing = (gridSize * gridSize);

            var stepsToMiddleOfLine = DistanceToAccessPort(square, gridSize, minNumInRing, maxNumInRing);

            return stepsToMiddleOfLine + ring;
        }

        private Tuple<int, int> RingAndGridSize(int square)
        {
            var ring = 0;
            var currentSquare = 1;
            var gridSize = 1;

            while (currentSquare < square)
            {
                ring++;
                gridSize += 2;
                currentSquare = gridSize * gridSize; //increase gridsize to simulate another square spiraling aroun the current grid
            }

            return new Tuple<int, int>(ring, gridSize);
        }

        private int DistanceToAccessPort(int square, int gridSize, int minNumInRing, int maxNumInRing)
        {
            var sideMinNum = minNumInRing;
            var sideMaxNum = minNumInRing + (gridSize - 1);

            while (square > sideMaxNum)
            {
                sideMinNum += gridSize - 1;
                sideMaxNum += gridSize - 1;
            }

            return Math.Abs(sideMinNum + ((gridSize - 2) / 2) - square);
        }
    }
}
