﻿using System;
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

        public void HeapSort()
        {
            BuidHeap(array.Length);
            for (int i = array.Length-1; i > 0; i--)
            {
                Swap(0, i);         // меняем местами корень (мак. элемент) и последний элемент
                BuidHeap(i - 1);    // уменьшаем длину массива на 1 (забываем про макс. элемент) и восстанавливаем свойство кучи
            }
        }
        private void BuidHeap(int size)
        {
            for (int i = size - 1; i >= 0; i--)
            {
                int child = i;

                while (child != 0)
                {
                    int parent = (child - 1) / 2;                           // индекс родительской записи
                    if (array[parent].CompareTo(array[child]) >= 0) break;  // если свойство выполняется, то выходим из цикла
                    Swap(parent, child);                                    // иначе меняем местами родительскую и дочернюю записи

                    child = parent;                                         // переходим к родительской записи
                }
            }
        }
        private void Swap(int first_index, int second_index)
        {
            T temp = array[first_index];
            array[first_index] = array[second_index];
            array[second_index] = temp;
        }
    }
}
