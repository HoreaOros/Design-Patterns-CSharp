using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator_SequenceLibrary
{
    internal class FibonacciEnumerator
    {
        private int _numberOfValues;
        private int _currentPosition;
        private int _previousTotal;
        private int _currentTotal;

        public FibonacciEnumerator(int numberOfValues)
        {
            _numberOfValues = numberOfValues;
        }
    }
}
