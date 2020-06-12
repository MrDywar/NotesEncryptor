using System.Collections.Generic;

namespace NotesEncryptor
{
    public class SearchNavigator
    {
        private List<int> _indexes = new List<int>();
        private int _currentIndex;

        public int Count { get { return _indexes.Count; } }

        public void AddIndex(int index)
        {
            _indexes.Add(index);
        }

        public void Clear()
        {
            _indexes.Clear();
            _currentIndex = 0;
        }

        public int GetNextIndex()
        {
            if (_indexes.Count == 0)
                return 0;

            _currentIndex = (_currentIndex >= _indexes.Count - 1)
                ? _currentIndex
                : _currentIndex + 1;

            return _indexes[_currentIndex];
        }

        public int GetPrevIndex()
        {
            if (_indexes.Count == 0)
                return 0;

            _currentIndex = (_currentIndex > 0)
                ? _currentIndex - 1
                : 0;

            return _indexes[_currentIndex];
        }
    }
}
