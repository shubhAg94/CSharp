using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.IteratorPattern
{
    public class CustomList : IEnumerable
    {
        private object[] _objects;

        public CustomList()
        {
            _objects = new object[100];
        }

        public void Add(object obj)
        {
            _objects[_objects.Count()] = obj;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class ListEnumerator : IEnumerator
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Resert()
            {
                throw new NotImplementedException();
            }
        }
    }
}
