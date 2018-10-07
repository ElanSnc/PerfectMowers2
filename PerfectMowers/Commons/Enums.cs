using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectMowers.Commons
{
    public class Enums
    {
        public enum CardinalDirection
        {
            North = 1,
            East,
            South,
            West            
        }

        public enum CardinalDirectionToArray
        {
            North = 1,
            South = -1,
            East = 1,
            West = -1
        }

        public enum MovingDirection
        {
            Left = 1,
            Right
        }
    }
}
