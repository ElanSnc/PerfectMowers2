using PerfectMowers.Model;
using PerfectMowers.Models;
using PerfectMowers.Models.Positioning;
using PerfectMowers.Mowers;
using System;

namespace PerfectMowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //6,6 as dimensions because end position is 5,1 and as array is 0 based it has to be 6
            LawnField field = new LawnField(6,6);

            Position mower1Position = new Position(new Ubication(1,2), new Direction("N"));
            Position mower2Position = new Position(new Ubication(3,3), new Direction("E"));

            InstructionList mower1ListOfInstructions = new InstructionList("LMLMLMLMM");
            InstructionList mower2ListOfInstructions = new InstructionList("MMRMMRMRRM");

            Mower mower1 = new Mower(mower1Position, mower1ListOfInstructions);
            Mower mower2 = new Mower(mower2Position, mower2ListOfInstructions);

            mower1.NewFieldToBeOperated(field);
            mower2.NewFieldToBeOperated(field);

            mower1.OperateField();
            Console.WriteLine(mower1.GetPosition());

            ACMEMower ACMEmower = new Mower();

            ACMEmower.SaySomething();
           
            mower1.AskTheField();

            mower2.OperateField();            
            Console.WriteLine(mower2.GetPosition());
            mower1.SaySomething();
            mower2.AskTheField();
            

            Console.Read();
        }
    }
}
