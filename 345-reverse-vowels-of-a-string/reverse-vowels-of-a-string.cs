public class Solution {
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();
        int left = 0, right = s.Length - 1;
        string vowels = "aeiouAEIOU";

        while (left < right) {
            // Move left pointer until it finds a vowel
            while (left < right && !vowels.Contains(chars[left])) {
                left++;
            }
            // Move right pointer until it finds a vowel
            while (left < right && !vowels.Contains(chars[right])) {
                right--;
            }

            // Swap vowels
            if (left < right) {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
        }

        return new string(chars);
    }
}
