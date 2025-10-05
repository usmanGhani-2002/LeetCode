public class Solution {
    public int Compress(char[] chars) {
        int write = 0;
        int i = 0;

        while (i < chars.Length) {
            char currentChar = chars[i];
            int count = 0;

            while (i < chars.Length && chars[i] == currentChar) {
                i++;
                count++;
            }

            chars[write++] = currentChar;

           if (count > 1) {
                foreach (char c in count.ToString()) {
                    chars[write++] = c;
                }
            }
        }

        return write;
    }
}
