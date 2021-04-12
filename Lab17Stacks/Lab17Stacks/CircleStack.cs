using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stacks
{
    class CircleStack
    {
        private int _arraySize;
        private Circle[] _circleStack;
        private int _stackTop;
        

        
        

        public CircleStack(int arraySize)
        {
            _arraySize = arraySize;
            _circleStack = new Circle[_arraySize];
        }
        public bool IsEmpty()
        {
            if (_arraySize < 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if (_stackTop >= _arraySize)
            {
                return true;
            }
            return false;
        }

        public Circle Pop()
        {
            if (_stackTop > 0)
            {
                _stackTop--;
                return _circleStack[_stackTop];
            }
            return _circleStack[_stackTop];

        }

        public void Push(Circle newCircle)
        {
            //if (_stackTop < _arraySize)
            if (IsFull() == false)
            {
                _circleStack[_stackTop] = newCircle;
                _stackTop++;
            }
        }
    }
    
}
