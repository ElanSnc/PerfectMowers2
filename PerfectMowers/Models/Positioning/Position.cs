
using PerfectMowers.Model;
using static PerfectMowers.Commons.Enums;

namespace PerfectMowers.Models.Positioning
{
    public class Position
    {

        Ubication ubication;

        Direction direction;

        public Position()
        {
        }

        public Position(Ubication newUbication, Direction newDirection)
        {
            ubication = newUbication;
            direction = newDirection;
        }

        public void ChangeDirection(MovingDirection newDirection)
        {
            direction.ChangeDirection(newDirection);
        }

        public string getPosition()
        {
            return ubication.ToString() + direction.ToString();
        }

        public void ChangePosition(LawnField field)
        {
            ubication.ChangeUbication(direction.GetDirection(),field);
        }

        public Ubication getUbication() { return ubication; }

    }
}
