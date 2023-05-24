using System;

namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if (xs.Length != ys.Length)
            return false;

        for (int i = 0; i < xs.Length; i++)
        {
            if (!xs[i].Equals(ys[i]))
                return false;
        }
        return true;
    }
    public static void Swap<T>(T[] xs, int a, int b)
    {
        if (a < 0 || a >= xs.Length || b < 0 || b >= xs.Length)
        {
            throw new IndexOutOfRangeException("Invalid indices for swapping.");
        }
        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs.Length == 0)
            throw new Exception("Array is empty.");

        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs.Length == 0)
            throw new Exception("Array is empty.");

        return xs[xs.Length - 1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        if (xs.Length == 0)
            throw new Exception("Array is empty.");


        return xs[xs.Length / 2];
    }

    public static void Reverse<T>(T[] xs)
    {
        int start = 0;
        int end = xs.Length - 1;

        while (start < end)
        {
            T temp = xs[start];
            xs[start] = xs[end];
            xs[end] = temp;

            start++;
            end--;
        }
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        return xs.Count(x => x.Equals(element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        return string.Join(",", xs);
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        return xs.Count(predicate);
    }

    public static T Min<T>(T[] xs, Func<T, T, int> cmp)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> cmp)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        HashSet<T> set = new HashSet<T>();
        foreach (T x in xs)
        {
            if (!set.Add(x))
            {
                return false;
            }
        }
        return true;
    }
}