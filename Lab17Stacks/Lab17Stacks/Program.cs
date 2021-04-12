using System;

namespace Lab17Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myInts = new Stack<int>(10);
            myInts.Push(1);
            myInts.Push(2);
            myInts.Push(3);
            myInts.Push(45);
            myInts.Push(67);
            bool isFull = myInts.IsFull();
            bool isEmpty = myInts.IsEmpty();
            int y = myInts.Pop();






            Stack<string> myStrings = new Stack<string>(10);
            myStrings.Push("hello");
            myStrings.Push("World");
            bool isFilled = myStrings.IsFull();

            CharStack charStactFive = new CharStack(4);
            charStactFive.Push('a');
            charStactFive.Push('b');
            charStactFive.Push('c');
            charStactFive.Push('d');
            charStactFive.Push('e');



            IntStack tenInts = new IntStack(10);
            bool mt = tenInts.IsEmpty();

            tenInts.Push(456);
            mt = tenInts.IsEmpty();

            tenInts.Push(-25);
            tenInts.Push(100);
            int v1 = tenInts.Pop();
            int v2 = tenInts.Pop();
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);
            tenInts.Push(123);


            bool full = tenInts.IsFull();

        }
    }
}
