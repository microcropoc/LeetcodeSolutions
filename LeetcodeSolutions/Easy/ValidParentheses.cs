using LeetCodeTests.Common;
using System.Xml.Linq;

namespace LeetCodeTests.Easy;

public class ValidParentheses
{
    [Fact]
    public void Test1()
    {
        var s = "()[]{}";

        var result = IsValid(s);

        Assert.True(result);
    }


    public bool IsValid(string s)
    {
        var st = new Stack<char>();

        for (var i = 0; i < s.Count(); i++)
        {
            switch(s[i])
            {
                case '(':
                case '[':
                case '{':
                    st.Push(s[i]);
                    break;
                case ')':
                    if(st.Count == 0 || st.Pop() != '(')
                        return false;
                    break;
                case ']':
                    if (st.Count == 0 || st.Pop() != '[')
                        return false;
                    break;
                case '}':
                    if (st.Count == 0 || st.Pop() != '{')
                        return false;
                    break;
            }
        }

        return st.Count == 0;
    }
}
