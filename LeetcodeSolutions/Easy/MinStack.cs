using LeetCodeTests.Common;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LeetCodeTests.Easy;

public class MinStack
{
    [Fact]
    public void Test1()
    {
        var minStack = new MinStackStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        var min1 = minStack.GetMin(); // return -3
        minStack.Pop();
        minStack.Top();    // return 0
        var min2 = minStack.GetMin(); 

        Assert.Equal(-3, min1);
        Assert.Equal(-2, min2);
    }


    public class MinStackStack
    {
        Stack<int> s = new Stack<int>();
        Stack<int> ms = new Stack<int>();

        public void Push(int val)
        {
            s.Push(val);

            if(ms.Count == 0)
            {
                ms.Push(val);
            }
            else
            {
                ms.Push(Math.Min(val, ms.Peek()));
            }
        }

        public void Pop()
        {
            s.Pop();
            ms.Pop();
        }

        public int Top()
        {
            return s.Peek();
        }

        public int GetMin()
        {
            return ms.Peek();
        }
    }
}
