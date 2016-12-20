using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class NYPaperIterator : IIterator
    {
        private List<string> _reporters;
        private int _current;

        public NYPaperIterator(List<string> _reporters)
        {
            this._reporters = _reporters;
            _current = 0;
        }

        public string CurrentItem()
        {
            return _reporters.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reporters.Count;
        }

        public string Next()
        {
            return _reporters.ElementAt(_current++);
        }
    }
}
