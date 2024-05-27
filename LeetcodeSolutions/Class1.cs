using System.Text;

namespace LeetcodeSolutions
{
    public class Solution
    {
        public string MergeAlternately1768(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int i1 = 0;
            int i2 = 0;
            while (true)
            {
                if (word1.Length <= i1 && word2.Length <= i2) break;
                if (word1.Length > i1) sb.Append(word1[i1]);
                if (word2.Length > i2) sb.Append(word2[i2]);
                i1++;
                i2++;
            }
            return sb.ToString();
        }
    }
}
