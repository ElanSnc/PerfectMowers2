using PerfectMowers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectMowers.Models
{
    public class InstructionList
    {
        readonly Queue<char> instructions;

        public int Count { get { return instructions.Count; } }

        public InstructionList(string listOfInstructions)
        {
            instructions = new Queue<char>();           

            foreach (char c in listOfInstructions)
            {
                instructions.Enqueue(c);
            }            
        }

        public int PendingInstructions()
        {
            return instructions.Count;
        }

        public char? getNextInstruction()
        {

            if (instructions.Count > 0)
            {
                return instructions.Dequeue();
            }

            return null;
        }
    }
}
