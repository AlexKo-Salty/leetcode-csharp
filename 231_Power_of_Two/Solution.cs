public class Solution
{
    //BitWise Operation:
    // Since Power of Two no should be 1111111110.
    public bool IsPowerOfTwo(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }

    //By Loop
    //public bool IsPowerOfTwo(int n)
    //{
    //    if (n < 1)
    //        return false;
    //    if (n == 1 || n == 2)
    //        return true;
    //    if (n % 2 != 0)
    //        return false;

    //    while (2 < n)
    //    {
    //        n = n / 2;
    //        if (n % 2 != 0)
    //            return false;
    //    }

    //    return n == 2;
    //}
}