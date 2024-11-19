using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Oefening
{
    public class Counter
    {
        public int CounterValue { get; set; }

        public void ResetCounter()
        {
            CounterValue = 0;
        }

        public void IncreaseCounter()
        {
            CounterValue++;
        }

        public void DecreaseCounter()
        {
            CounterValue--;
        }

        public void Value(int value)
        {
            CounterValue += value;
        }
    }
}
