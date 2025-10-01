public class Solution {
    public string ReverseVowels(string s) {
        string vowels = new string(s.Where(c => "aeiouAEIOU".Contains(c)).ToArray());
        int len = vowels.Length;
        char[] chars = s.ToCharArray();


        for(int i = 0 ; i < chars.Length ; i++){
            if("aeiouAEIOU".Contains(chars[i])){
                chars[i] = vowels[len-1];
                len--;
            }
        }
        return new string(chars);
    }
}