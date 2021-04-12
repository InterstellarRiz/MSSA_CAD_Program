using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17Stacks
{
    class StringStack
    {
        //field prop
        private int _arraySize { get; set; }
        private string[] _stringStack { get; set; }
        private int _stackTop { get; set; }

        //constructor
        public StringStack (int arraySize)
        {
            _arraySize = arraySize;
            _stringStack = new string[_arraySize];
        }
        //methods
        public bool IsEmpty()
        {
            if(_arraySize < 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if(_stackTop >= _arraySize)
            {
                return true;
            }
            return false;
        }

        public string Pop()
        {
            if(_stackTop > 0)
            {
                _stackTop--;
                return _stringStack[_stackTop];
            }
            return "";
            
        }

        public void Push(string addString)
        {
            //if (_stackTop < _arraySize)
            if (IsFull() == false)
            {
                _stringStack[_stackTop] = addString;
                _stackTop++;
            }
        }

    }
}
