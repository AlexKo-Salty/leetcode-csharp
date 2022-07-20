public int NumMatchingSubseq(string s, string[] words)
        {
            int count = 0;
            Dictionary<string, bool> reference = new Dictionary<string, bool>();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (reference.ContainsKey(word))
                {
                    if (reference[word])
                    {
                        count++;
                    }
                }
                else
                {
                    int refIndex = 0;
                    int wordIndex = 0;
                    while (refIndex < s.Length && wordIndex < word.Length)
                    {
                        if (s[refIndex] == word[wordIndex])
                        {
                            wordIndex++;
                        }
                        refIndex++;
                    }

                    if (wordIndex == word.Length)
                    {
                        count++;
                        reference.Add(word, true);
                    }
                    else
                    {
                        reference.Add(word, false);
                    }
                }
            }
            return count;
        }
        /*
         * Time Limited Exceeded. Reason maybe cause by using IndexOf method & Substring method.
         */
        //public int NumMatchingSubseq(string s, string[] words)
        //{
        //    int currentIndex = 0;
        //    int count = 0;
        //    Dictionary<string, bool> reference = new Dictionary<string, bool>();
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        string word = words[i];
        //        string currentString = s;
        //        bool canCount = true;
        //        if (reference.ContainsKey(word))
        //        {
        //            if (reference[word])
        //            {
        //                count++;
        //            }
        //        }
        //        else
        //        {
        //            for (int j = 0; j < word.Length; j++)
        //            {
        //                if (s.Contains(word))
        //                {
        //                    break;
        //                }
        //                currentIndex = currentString.IndexOf(word[j]);
        //                if (currentIndex > -1)
        //                {
        //                    currentString = currentString.Substring(currentIndex + 1);
        //                }
        //                else
        //                {
        //                    canCount = false;
        //                    break;
        //                }
        //            }
        //            if (canCount)
        //            {
        //                reference.Add(word, true);
        //                count++;
        //            }
        //            else
        //            {
        //                reference.Add(word, false);
        //            }
        //        }
        //    }
        //    return count;
        //}