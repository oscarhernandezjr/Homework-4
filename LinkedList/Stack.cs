using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4.LinkedList
{
    public class MyStack
    {
        private LinkedList _stack = new LinkedList();
        
        public LinkedList Stack {  get { return _stack; } }

        public void Push(int Value) 
        {
            _stack.InsertFirst(Value);
        }

        public Node Pop()
        {
            return _stack.DeleteFirst();
        }
    }
}
