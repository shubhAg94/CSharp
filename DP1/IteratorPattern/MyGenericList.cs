using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern
{
    public class MyGenericList<T> : IEnumerable<T> 
    {
        private T[] _objects;

        private int arrayIndex = 0;
        public MyGenericList()
        {
            _objects = new T[100];
        }

        public void Add(T obj)
        {
            _objects[arrayIndex] = obj;
            arrayIndex++;
        }

        public T this[int index]
        {
            get { return _objects[index]; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyGenericListEnumerator<T>(_objects);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        internal class MyGenericListEnumerator<T> : IEnumerator<T>
        {
            private int _currentIndex = -1;

            private T[] _objects;

            internal MyGenericListEnumerator(T[] _objects)
            {
                this._objects = _objects;
            }

            public T Current
            {
                get
                {
                    try
                    {
                        return _objects[_currentIndex];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                //throw new System.NotImplementedException();
            }

            public bool MoveNext()
            {
                _currentIndex++;
                return (_currentIndex < _objects.Count());
            }

            public void Reset()
            {
                _currentIndex = -1;
            }
        }
    }
}
