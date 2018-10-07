using PerfectMowers.Commons;
using static PerfectMowers.Commons.Enums;

namespace PerfectMowers.Models.Positioning
{
    public class Direction
    {
        private CardinalDirection direction;

        public Direction(string newDirection)
        {
            direction = Directions.GetDirection(newDirection);
        }

        public void ChangeDirection(MovingDirection newDirection)
        {
            direction = Directions.SwitchDirection(direction, newDirection);
        }
           
        public CardinalDirection GetDirection()
        {
            return direction;
        }

        public override string ToString()
        {
            return Directions.GetDirection(direction);
        }
    }
}
