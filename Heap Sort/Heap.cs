using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Heap<T> where T : IComparable
    {
        private T[] array;

        public Heap(T[] array) => this.array = array;


    }
}
