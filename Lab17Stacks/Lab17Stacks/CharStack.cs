using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stacks
{
    class CharStack
    {
        //   F i e l d s   &   P r o p e r t i e s

        private int _size;       // initially 0
        private char[] _stack;      // initially null
        private int _topOfStack; // initially 0


        //   C o n s t r u c t o r s
        public CharStack(int size)
        {
            _size = size;
            _stack = new char[size];
        }


        //   M e t h o d s

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
            if (_topOfStack >= _size)
            {
                return true;
            }

            return false;
        }

        public char Pop()
        {
            if(_topOfStack > 0)
            {
                _topOfStack--;
                return _stack[_topOfStack];
            }
            return '\0'; //ascii
            
        }
        public void Push(char valuetoPush)
        {
            if(_topOfStack < _size)
            {
                _stack[_topOfStack] = valuetoPush;
                _topOfStack++;
            }

        }

    }
}
