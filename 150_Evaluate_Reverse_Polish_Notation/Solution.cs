public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<string> vs = new Stack<string>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (int.TryParse(tokens[i], out int blah))
            {
                vs.Push(tokens[i]);
            }
            else
            {
                int second = int.Parse(vs.Pop());
                int first = int.Parse(vs.Pop());

                switch (tokens[i])
                {
                    case "+":
                        vs.Push((first + second).ToString());
                        break;
                    case "-":
                        vs.Push((first - second).ToString());
                        break;
                    case "*":
                        vs.Push((first * second).ToString());
                        break;
                    case "/":
                        vs.Push((first / second).ToString());
                        break;
                    default:
                        break;
                }

            }
        }
        return int.Parse(vs.Pop());
    }
}