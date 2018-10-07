using PerfectMowers.Model;
using PerfectMowers.Mowers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectMowers.Models.MowerOperator
{
    class MowerOperator
    {
        Mower mower;
        LawnField field;

        public MowerOperator(Mower mower, LawnField field)
        {
            this.mower = mower;
            this.field = field;
        }

        public void OperateMower()
        {
           
        }

    }
}
