using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stacks
{
    class IntStack
    {
        // Fields and Properties
        private int _size; // initially 0
        private int[] _stack; // initially null
        private int _topOfStack; // initially 0
        //Constructors
         public IntStack(int size)
         {
            _size = size;
            _stack = new int[size];
         }
        //
        public void Push(int valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
                //_topOfStack++;
            }
            
        }
        public int Pop()
        {
            if(_topOfStack > 0)
            {
                //_topOfStack--;
                return _stack[-- _topOfStack];
            }
            return 0;
           
        }

        public bool IsEmpty()
        {
            if (_topOfStack > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsFull()
        {
            if(_topOfStack >= _size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
