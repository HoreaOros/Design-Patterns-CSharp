using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Iterator_MP3Library
{
    internal class MP3Enumerator
    {
        private string _startingPath;

        public MP3Enumerator(string startingPath)
        {
            _startingPath = startingPath;
        }
    }
}
