using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Count = System.Int32;

namespace Solutions;
public class HashCodeSolution1
{
    /*
     * LeetCode 383. Ransom Note
     * https://leetcode.com/problems/ransom-note/description/?envType=study-plan-v2&envId=top-interview-150
     */
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }

        Dictionary<char,Count> frequencyCount = new();

        foreach (char c in magazine)
        {
            if (frequencyCount.ContainsKey(c))
            {
                frequencyCount[c]++;
            }
            else
            {
                frequencyCount.Add(c, 1);
            }
        }

        foreach (char c in ransomNote)
        {
            if (!frequencyCount.ContainsKey(c) || --frequencyCount[c] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
