public class Solution
        {
            public bool IsPalindrome(string s)
            {
                int start = 0;
                int end = s.Length - 1;
                s = s.ToLower();

                while (start < end)
                {
                    if (!Char.IsLetterOrDigit(s[start]))
                    {
                        start++;
                    }
                    else if (!Char.IsLetterOrDigit(s[end]))
                    {
                        end--;
                    }
                    else
                    {
                        if (s[start] != s[end])
                        {
                            return false;
                        }
                        else
                        {
                            start++;
                            end--;
                        }
                    }
                }

                return true;
            }
        }