        public class Solution
        {
            public bool IsValidSudoku(char[][] board)
            {
                HashSet<char>[] rowDict = new HashSet<char>[9];
                HashSet<char>[] colDict = new HashSet<char>[9];
                HashSet<char>[] regionDict = new HashSet<char>[9];
                for (int i = 0; i < rowDict.Length; i++)
                {
                    rowDict[i] = new HashSet<char>();
                    colDict[i] = new HashSet<char>();
                    regionDict[i] = new HashSet<char>();
                }

                int row = 0;
                int col = 0;
                while (row < 9 && col < 9)
                {
                    if (board[row][col] != '.')
                    {
                        if (!rowDict[row].Add(board[row][col]))
                            return false;
                        if (!colDict[col].Add(board[row][col]))
                            return false;

                        int regionIndex = col / 3 + ((row / 3) * 3);
                        //if (col < 3 && row < 3)
                        //    regionIndex = 0;
                        //else if (col < 6 && row < 3)
                        //    regionIndex = 1;
                        //else if(col < 9 && row < 3)
                        //    regionIndex = 2;
                        //else if(col < 3 && row < 6)
                        //    regionIndex = 3;
                        //else if(col < 6 && row < 6)
                        //    regionIndex = 4;
                        //else if(col < 9 && row < 6)
                        //    regionIndex = 5;
                        //else if(col < 3 && row < 9)
                        //    regionIndex = 6;
                        //else if(col < 6 && row < 9)
                        //    regionIndex = 7;
                        //else if(col < 9 && row < 9)
                        //    regionIndex = 8;

                        if (!regionDict[regionIndex].Add(board[row][col]))
                            return false;
                    }

                    if (col == 8)
                    {
                        col = 0;
                        row++;
                    }
                    else
                    {
                        col++;
                    }
                }

                return true;
            }
        }