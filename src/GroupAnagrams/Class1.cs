using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    ///Given an array of strings, group anagrams together.

///For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
///Return:

///[
///  ["ate", "eat","tea"],
///  ["nat","tan"],
///  ["bat"]
///]
///Note:
///For the return value, each inner list's elements must follow the lexicographic order.
///All inputs will be in lower-case.
    public class Class1
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var ordered = strs.OrderBy(s => s).ToArray();
            Dictionary<string, List<string>> keyed = new Dictionary<string, List<string>>();
            for (int i = 0; i < ordered.Length; i++)
            {
                string sKey = new String(ordered[i].ToCharArray().OrderBy(c => c).ToArray<char>());
                if (keyed.ContainsKey(sKey))
                {
                    ((List<string>)keyed[sKey]).Add(ordered[i]);
                }
                else
                {
                    keyed.Add(sKey, new List<string>() { ordered[i] });
                }
            }
            IList<IList<string>> result = new List<IList<string>>(keyed.Keys.Count);
            foreach (KeyValuePair<string, List<string>> kv in keyed)
            {
                result.Add(kv.Value);
            }
            return result;
        }
    }
}
