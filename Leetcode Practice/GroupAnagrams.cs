
public class GroupAnagramsProblem
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> sortedDict = new Dictionary<string, IList<string>>();
        foreach (string str in strs)
        {
            string anagram = String.Concat(str.OrderBy(c => c));
            if (sortedDict.ContainsKey(anagram))
            {
                sortedDict[anagram].Add(str);
            }
            else
            {
                sortedDict[anagram] = new List<string> { str };
            }
        }
        return sortedDict.Values.ToList();
    }

    public IList<IList<string>> GroupAnagramsHashmap(string[] strs)
    {
        Dictionary<string, IList<string>> result = new Dictionary<string, IList<string>>();
        foreach (string str in strs)
        {
            int[] count = new int[26];
            foreach (char c in str)
            {
                int idx = (int)c - (int)'a';
                count[idx] += 1;
            }
            if (result.ContainsKey(String.Join(",", count)))
            {
                result[String.Join(",", count)].Add(str);
            }
            else
            {
                result.Add(String.Join(",", count), new List<string>() { str });
            }
        }
        return result.Values.ToList();
    }
}

