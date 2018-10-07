using PerfectMowers.Commons;
using PerfectMowers.Model;
using PerfectMowers.Models;
using PerfectMowers.Models.Positioning;
using System;

namespace PerfectMowers.Mowers
{
    public class Mower : ACMEMower
    {
        public Position position;

        private LawnField fieldToBeOperated;

        readonly InstructionList instructions;

        public Mower()
        {
           
        }

        public Mower(Position newPosition, InstructionList newInstructions)
        {
            position = newPosition;

            instructions = newInstructions;
        }

        public void NewFieldToBeOperated(LawnField newField)
        {
            fieldToBeOperated = newField;
        }

        public void OperateField()
        {
            try
            {
                while (instructions.Count > 0)
                {
                    ExecuteInstruction((char)instructions.getNextInstruction());
                }
            }
            catch (NullReferenceException noFieldToOperate)
            {
                throw new Exception("There is no field to be operated" + noFieldToOperate.StackTrace.ToString());
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Woops, You have got out of bounds and cutted the rare plants, you're fired BTW");
            }
        }

        private void ExecuteInstruction(char instruction)
        {
            if (instruction.ToString() == "L" || instruction.ToString() == "R")
            {
                position.ChangeDirection(Directions.GetMovingDirection(instruction.ToString()));
            }
            else
            {
                Move();
            }
        }

        private void Move()
        {
            try
            {                
                position.ChangePosition(fieldToBeOperated);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            fieldToBeOperated.setMowerPosition(this);
        }

        public string GetPosition()
        {
            return position.getPosition();
        }

        public void AskTheField()
        {
            fieldToBeOperated.WhereIsTheMowerAt();
        }

        public void SaySomething()
        {
            Console.WriteLine("Boop Boop");
        }
    }

}

