using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Oefening
{
    public class Counter
    {
        public int _counter { get; set; }

        public void ResetCounter()
        {
            _counter = 0;
        }

        public void IncreaseCounter()
        {
            _counter++;
        }

        public void DecreaseCounter()
        {
            _counter--;
        }

        public void Value(int value)
        {
            _counter += value;
        }
    }
}
