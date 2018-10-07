using PerfectMowers.Interfaces;
using PerfectMowers.Models.Positioning;
using PerfectMowers.Mowers;
using System;
using System.Collections;

namespace PerfectMowers.Model
{
    public class LawnField : IEnumerable , ILawnfield
    {
        private int[,] field;

        public LawnField(int xAxisLength , int yAxisLength)
        {
            field = new int[xAxisLength, yAxisLength];
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        private void ClearMowerPosition()
        {
            field = new int[field.GetLength(1), field.GetLength(0)];
        }

        public void setMowerPosition(Mower mower)
        { 
            int mowerPositionY = mower.position.getUbication().GetUbicationY();
            int mowerPositionX = mower.position.getUbication().GetUbicationX();

            ClearMowerPosition();

            field[mowerPositionY, mowerPositionX] = 1; 
        }

        public Tuple <int,int> GetBounds()
        {
            return new Tuple<int,int>(field.GetLength(0),field.GetLength(1));
        }

        public string getMowerPosition()
        {  

            for (int x = 0; x < field.GetLength(0); x++)
            {                
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y] == 1) return new Ubication(y, x).ToString();
                }
            }

            return "I've seen no mowers over there buddy";
        }

        public void WhereIsTheMowerAt()
        {
            Console.WriteLine("The farm owner says "+ getMowerPosition());
        }
    }
}
