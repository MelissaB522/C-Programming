using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStack
{
    class Stack
    {
        private object[] items;
        private int stackPointer = 0;

        public Stack (int size)
        {
            items = new object[size];
        }

        public object Pop()
        {
            return items[--stackPointer];
        }

        public void Push(object anItem)
        {
            items[stackPointer] = anItem;
            stackPointer++;
        }
    }
}
