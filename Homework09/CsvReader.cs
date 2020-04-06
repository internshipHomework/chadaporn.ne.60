using System;
using System.IO;

namespace work09
{
    internal class CsvReader
    {
        private TextReader reader;

        public CsvReader(TextReader reader)
        {
            this.reader = reader;
        }

        public object Configuration { get; internal set; }

        internal bool Read()
        {
            throw new NotImplementedException();
        }

        internal T GetRecord<T>()
        {
            throw new NotImplementedException();
        }
    }
}