public class Solution
{
    public class MinStack
    {
        public class numWithMin
        {
            public int num { get; set; }
            public int currMin { get; set; }
        }

        private Stack<numWithMin> stack { get; set; }

        public MinStack()
        {
            stack = new Stack<numWithMin>();
        }

        public void Push(int val)
        {
            if (val < this.GetMin())
                stack.Push(new numWithMin { num = val, currMin = val });
            else
                stack.Push(new numWithMin { num = val, currMin = this.GetMin() });
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek().num;
        }

        public int GetMin()
        {
            return stack.Count == 0 ? int.MaxValue : stack.Peek().currMin;
        }
    }
}