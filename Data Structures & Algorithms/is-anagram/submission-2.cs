public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var dictS = new Dictionary<char,int>();
        var dictT = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++) {
            dictS.TryGetValue(s[i], out var valueS);
            dictT.TryGetValue(t[i], out var valueT);
            dictS[s[i]] = valueS + 1;
            dictT[t[i]] = valueT + 1;
        }

        foreach (KeyValuePair<char, int> pair in dictS) {
           
            if (!dictT.ContainsKey(pair.Key) || dictT[pair.Key] != pair.Value) {
            return false;
            };
        }
        return true;

    }
}
