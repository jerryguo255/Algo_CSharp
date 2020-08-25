using System;
using System.Linq;

namespace Lib_0150_EvaluateReversePolishNotation
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            var stringStack = new StringStack(tokens.Length);
            int secondNum;
            int firstNum;
            //"4", "13", "5", "/", "+"
            foreach (var t in tokens)
            {
                switch (t)
                {
                    default:
                        stringStack.Push(t);
                        break;


                    case "+":
                        secondNum = int.Parse(stringStack.Pop());
                        firstNum = int.Parse(stringStack.Pop());
                        stringStack.Push((firstNum +secondNum ).ToString());
                        break;
                    case "-":
                         secondNum = int.Parse(stringStack.Pop());
                         firstNum = int.Parse(stringStack.Pop());
                        stringStack.Push((firstNum-secondNum).ToString());
                        break;
                    case "*":
                        secondNum = int.Parse(stringStack.Pop());
                        firstNum = int.Parse(stringStack.Pop());
                        stringStack.Push((firstNum* secondNum ).ToString());
                        break;
                    case "/":
                        secondNum = int.Parse(stringStack.Pop());
                        firstNum = int.Parse(stringStack.Pop());
                        stringStack.Push((firstNum/ secondNum ).ToString());
                        break;
                    
                }
            }
            return int.Parse(stringStack.Pop()); 
        }
    }

    public class StringStack
    {
        public int MaxSize { get; set; }
        private int count;
        private readonly string[] _vals;
        
        public StringStack(int maxSize)
        {
            MaxSize = maxSize;
            _vals = new string[maxSize];
        }

        
       

        public void Push(string x)
        {
            if (count == MaxSize) return;
            count++;
            _vals[count - 1] = x;

        }

        public string Pop()
        {
            if (count == 0) return "";
            count--;
            return _vals[count];
        }
    }
}
