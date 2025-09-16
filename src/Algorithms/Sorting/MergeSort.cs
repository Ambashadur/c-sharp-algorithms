using System;

namespace Algorithms.Sorting;

internal static class MergeSort
{
    public static void Sort(int[] a)
    {
        if (a.Length <= 1) return;

        int m = a.Length / 2;
        int[] left = GetSubarray(a, 0, m - 1);
        int[] right = GetSubarray(a, m, a.Length - 1);

        Sort(left);
        Sort(right);

        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j]) a[k++] = left[i++];
            else a[k++] = right[j++];
        }

        while (i < left.Length) a[k++] = left[i++];
        while (j < right.Length) a[k++] = right[j++];
    }
    
    private static int[] GetSubarray(int[] a, int si, int ei)
    {
        int[] result = new int[ei - si + 1];
        Array.Copy(a, si, result, 0, ei - si + 1);

        return result;
    }
}
