    public class Solution
    {
        public IListIListint Generate(int numRows)
        {
            IListIListint result = new ListIListint();
            int i = 1;
            while (i = numRows)
            {
                Listint row = new Listint();
                if (i == 1)
                {
                    row.Add(1);
                }
                else if (i == 2)
                {
                    row.Add(1);
                    row.Add(1);
                }
                else
                {
                    row.Add(1);
                    for (int j = 1; j  i - 1; j++)
                    {
                        row.Add(result[1][0] + result[1][1]);
                        row.Add(result[i - 2][j - 1] + result[i - 2][j]);
                    }
                    row.Add(1);
                }

                result.Add(row);
                i++;
            }

            return result;
        }
    }