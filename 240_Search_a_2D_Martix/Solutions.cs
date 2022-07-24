        public class Solution
        {
            //Try Binary Search Method
            public bool SearchMatrix(int[][] matrix, int target)
            {
                //Added Length = 0 array case for prevent extra time needed to solve
                if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                {
                    return false;
                }

                int n = matrix[0].Length - 1;
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i][n] >= target)
                    {
                        if (binarySearch(matrix[i], target)) return true;
                    }
                }
                return false;
            }

            public bool binarySearch(int[] row, int target)
            {
                int left = 0;
                int right = row.Length - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (target == row[mid])
                        return true;
                    else if (target < row[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                return false;
            }

            //Time Complex: O(N^2)
            //public bool SearchMatrix(int[][] matrix, int target)
            //{
            //    int n = matrix[0].Length - 1;
            //    for (int i = 0; i < matrix.Length; i++)
            //    {
            //        if (matrix[i][n] >= target && target >= matrix[i][0])
            //        {
            //            for(int j = 0;j < matrix[i].Length; j++)
            //            {
            //                if (matrix[i][j] == target)
            //                {
            //                    return true;
            //                }
            //            }
            //        }
            //    }
            //    return false;
            //}
        }