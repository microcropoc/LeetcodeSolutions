namespace LeetCodeTests.Easy;

public class ImplementQueueUsingStacks
{
    [Fact]
    public void Test1()
    {
        MyQueue myQueue = new MyQueue();
        myQueue.Push(1);
        myQueue.Push(2);
        var r1 = myQueue.Peek();
        var r2 = myQueue.Pop();
        myQueue.Empty();

        Assert.Equal(1, r1);
        Assert.Equal(1, r2);
    }

    public class MyQueue
    {
        Stack<int> i = new Stack<int>();
        Stack<int> o = new Stack<int>();

        public void Push(int x)
        {
            i.Push(x);
        }

        public int Pop()
        {
            if (o.Count == 0)
                while (i.Count != 0)
                    o.Push(i.Pop());
            return o.Pop();
        }

        public int Peek()
        {
            if (o.Count == 0)
                while (i.Count != 0)
                    o.Push(i.Pop());
            return o.Peek();
        }

        public bool Empty()
        {
            return i.Count == 0 && o.Count == 0;
        }
    }
}
