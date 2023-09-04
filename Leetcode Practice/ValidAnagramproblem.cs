using System;
using System.Linq;
public class ValidAnagramProblem
{
    public bool IsAnagram(string s, string t)
    {
        s = String.Concat(s.OrderBy(c => c));
        t = String.Concat(t.OrderBy(c => c));
        return s == t;
    }

    public bool isAnagramHashmap(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            countS[s[i]] = 1 + countS.GetValueOrDefault(s[i], 0);
            countT[t[i]] = 1 + countT.GetValueOrDefault(t[i], 0);
        }
        foreach (char key in countS.Keys)
        {
            if (countS[key] != countT.GetValueOrDefault(key, 0)) return false;
        }
        return true;
    }
}