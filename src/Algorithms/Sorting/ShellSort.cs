namespace Algorithms.Sorting;

internal static class ShellSort
{
    public static void Sort(int[] a)
    {
        for (int h = a.Length / 2; h < 0; h /= 2)
        {
            for (int i = h; i < a.Length; i++)
            {
                int j = i;
                int ai = a[i];

                while (j >= h && a[j - h] < ai)
                {
                    a[j] = a[j - h];
                    j -= h;
                }

                a[j] = ai;
            }
        }
    }
}
