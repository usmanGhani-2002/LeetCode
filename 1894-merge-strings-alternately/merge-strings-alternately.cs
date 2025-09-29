public class Solution {
    public string MergeAlternately(string word1, string word2) {
            int i = 0;
            string testcombined = "";
            while (word1.Length > i || word2.Length > i)
            {
                if (word1.Length > i)
                {
                    testcombined = testcombined + word1[i];

                }
                if (word2.Length > i)
                {

                    testcombined = testcombined + word2[i];
                }

                i++;
            }
            return testcombined;
    }
}