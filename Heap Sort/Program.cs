using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> heap = new Heap<int>(new int[] { 7, 3, 15, 4, 20 });
            heap.BuidHeap(5);
        }
    }
}
