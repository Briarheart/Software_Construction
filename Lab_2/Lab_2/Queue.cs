﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Queue : IQueue
    {
        private double[] array;
        private int pointerEnd;
        private int pointerForward;

        public Queue()
        {
            array = new double[10];
            pointerEnd = 0;
            pointerForward = 0;
        }

        public void AddToTheEnd(double element)
        {
            if (pointerEnd == array.Length)
                ExtendArray(10);
            array[pointerEnd] = element;
            pointerEnd++;
        }

        public void ExtendArray(int count)
        {
            var tmpArray = new double[array.Length + count];
            array.CopyTo(tmpArray, 0);
            array = tmpArray;
        }

        public double RemoveForward()
        {
            if (pointerEnd == pointerForward)
                throw new InvalidOperationException("Queue is empty");
            var element = array[pointerForward];
            pointerForward++;
            return element;
        }
    }
}
