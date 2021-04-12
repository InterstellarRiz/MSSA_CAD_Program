namespace Lab17Stacks
{
    class Stack<T>
    {
        private int _size; // initially 0
        private T[] _stack; // initially null
        private int _topOfStack; // initially 0
                                 //Constructors
        public Stack(int size)
        {
            _size = size;
            _stack = new T[size];
        }
        //
        public void Push(T valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack++] = valueToPush;
                //_topOfStack++;
            }

        }
        public T Pop()
        {
            if (_topOfStack > 0)
            {
                //_topOfStack--;
                return _stack[--_topOfStack];
            }
            return default(T);

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
            if (_topOfStack >= _size)
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
