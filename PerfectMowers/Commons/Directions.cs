
using System.Collections.Generic;
using static PerfectMowers.Commons.Enums;

namespace PerfectMowers.Commons
{
    public static class Directions
    {
        public static CardinalDirection GetDirection(string direction)
        {
            switch (direction)
            {
                case "N":
                    return CardinalDirection.North;
                case "E":
                    return CardinalDirection.East;
                case "S":
                    return CardinalDirection.South;
                case "W":
                    return CardinalDirection.West;
                default:
                    return CardinalDirection.North;
            }
        }

        public static string GetDirection(CardinalDirection direction)
        {
            switch (direction)
            {
                case CardinalDirection.North:
                    return "N";
                case CardinalDirection.East:
                    return "E";
                case CardinalDirection.South:
                    return "S";
                case CardinalDirection.West:
                    return "W";
                default:
                    return "N";
            }           
        }

        public static MovingDirection GetMovingDirection(string direction)
        {
            switch (direction)
            {
                case "L":
                    return MovingDirection.Left;
                case "R":
                    return MovingDirection.Right;
                default:
                    return MovingDirection.Right;
            }
        }

        public static CardinalDirectionToArray GetCardinalDirectionToArrayEquivalent(CardinalDirection direction)
        {
            switch (direction)
            {
                case CardinalDirection.North:
                    return CardinalDirectionToArray.North;
                case CardinalDirection.East:
                    return CardinalDirectionToArray.East;
                case CardinalDirection.South:
                    return CardinalDirectionToArray.South;
                case CardinalDirection.West:
                    return CardinalDirectionToArray.West;
                default:
                    return CardinalDirectionToArray.North;
            }
        }

        public static CardinalDirection SwitchDirection(CardinalDirection currentDirection, MovingDirection movingTo)
        {
            if (movingTo == MovingDirection.Right) return moveRight(currentDirection);
            else return moveLeft(currentDirection);
        }

        private static CardinalDirection moveRight(CardinalDirection currentDirection)
        {
            if (currentDirection == CardinalDirection.West)
            {
                return CardinalDirection.North;
            }
            else
            {
                return currentDirection + 1;
            }
        }

        private static CardinalDirection moveLeft(CardinalDirection currentDirection)
        {
            if (currentDirection == CardinalDirection.North)
            {
                return CardinalDirection.West;
            }
            else
            {
                return currentDirection - 1;
            }
        }
    }
}
