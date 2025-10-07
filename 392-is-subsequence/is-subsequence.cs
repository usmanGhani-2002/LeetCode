public class Solution {
    public bool IsSubsequence(string s, string t) {
        int n =0;
        for(int i = 0; i < t.Length ; i++){
            if(s.Length > 0){
                if(t[i] == s[n] && n != s.Length ){
                    n++;
                }
                if(n == s.Length){
                    break;
                }
            }
            
        }
        if(n == s.Length){
            return true;
        }
        else {
            return false;
        }
    }
}