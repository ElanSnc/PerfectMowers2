
using PerfectMowers.Commons;
using PerfectMowers.Model;
using System;
using static PerfectMowers.Commons.Enums;

namespace PerfectMowers.Models.Positioning
{
    public class Ubication
    {
        int yAxis;

        int xAxis;

        public Ubication(int xAxisPosition = 0, int yAxisPosition = 0)
        {
            yAxis = yAxisPosition;
            xAxis = xAxisPosition;
        }
        
        public void SetUbication(int? yAxisPosition, int? xAxisPosition)
        {
            if (yAxisPosition != null)
            {
                SetUbicationY((int)yAxisPosition);
            }

            if (xAxisPosition != null)
            {
                SetUbicationX((int)xAxisPosition);
            }
        }

       

        internal void ChangeUbication(CardinalDirection direction, LawnField field)
        {
            Tuple<int, int> fieldBounds;

            fieldBounds = field.GetBounds();

            CardinalDirectionToArray directionToHeadOfInTheField = Directions.GetCardinalDirectionToArrayEquivalent(direction);

            if ((direction == CardinalDirection.North || direction == CardinalDirection.South) && fieldBounds.Item1 >= xAxis)
            {
                yAxis = yAxis + (int)directionToHeadOfInTheField;
            }
            else if ((direction == CardinalDirection.East || direction == CardinalDirection.West) && fieldBounds.Item2 >= yAxis)
            {
                xAxis = xAxis + (int)directionToHeadOfInTheField;
            }
            else throw new Exception("You can't go in that direction, you getting out of the field bonds");
        }

        private void SetUbicationY(int yAxisPosition)
        {
            yAxis = yAxisPosition;
        }

        private void SetUbicationX(int xAxisPosition)
        {
            xAxis = xAxisPosition;
        }

        public int GetUbicationX() { return xAxis; }

        public int GetUbicationY() { return yAxis; }

        public override string ToString()
        {
            return new string(yAxis.ToString() + " " + xAxis.ToString());
        }
    }
}
