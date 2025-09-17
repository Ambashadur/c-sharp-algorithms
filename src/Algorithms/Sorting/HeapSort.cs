namespace Algorithms.Sorting;

internal static class HeapSort
{
    public static void Sort(int[] a)
    {
        for (int i = a.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(a, a.Length, i);
        }

        for (int i = a.Length - 1; i > 0; i--)
        {
            (a[0], a[i]) = (a[i], a[0]);
            Heapify(a, i, 0);
        }
    }

    private static void Heapify(int[] a, int n, int i)
    {
        int max = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        max = left < n && a[left] > a[max] ? left : max;
        max = right < n && a[right] > a[max] ? right : max;

        if (max != i)
        {
            (a[i], a[max]) = (a[max], a[i]);
            Heapify(a, n, max);
        }
    }
}
