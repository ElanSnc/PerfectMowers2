using System;
using PerfectMowers.Model;
using PerfectMowers.Models;
using PerfectMowers.Models.Positioning;
using PerfectMowers.Mowers;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WhenMowerMoves_OutsideOfFieldBounds_ExceptionShouldBeThrown()
        {
            // Yep, You're right. there was suposed to be code there but for some unkown reason the project was made in .Net Core and i have no idea about net core testin'

           // Arrange
            LawnField field = new LawnField(5, 5);
            
            Position mower2Position = new Position(new Ubication(3, 3), new Direction("E"));
            
            InstructionList mower2ListOfInstructions = new InstructionList("MMRMMRMRRM");
            
            Mower mower2 = new Mower(mower2Position, mower2ListOfInstructions);
           
            mower2.NewFieldToBeOperated(field);

            // Act
            Exception ex = Assert.Throws<IndexOutOfRangeException>(() => mower2.OperateField());

            // Assert
            Assert.Equal("Woops, You have got out of bounds and cutted the rare plants, you're fired BTW", ex.Message);
        }
    }
}
