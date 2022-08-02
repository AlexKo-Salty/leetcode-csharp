public class Solution {
            //Binary Search Method
public int KthSmallest(int[][] matrix, int k)
{
                if (matrix.Length == 0 || matrix == null) return 0;

                int length = matrix.Length - 1;
                int left = matrix[0][0];
                int right = matrix[length][length];

                while (left < right)
                {
                    int mid = (left) + (right - left) / 2;
                    int count = 0;

                    for (int i = 0; i <= length; i++)
                    {
                        for (int j = 0; j <= length; j++)
                        {
                            if (matrix[i][j] <= mid)
                                count++;
                        }
                    }

                    if (count < k)
                        left = mid + 1;
                    else
                        right = mid;
                }

                return left;
}
}