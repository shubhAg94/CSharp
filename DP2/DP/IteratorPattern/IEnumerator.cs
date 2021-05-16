using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.IteratorPattern
{
    public interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Resert();
    }
}
