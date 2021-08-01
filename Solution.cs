public class Solution {
    public int LengthOfLongestSubstring(string s) {
      int length = 0; 
        List<char> caracter = new List<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (caracter.Contains(s[i]))
            {
                length = length > caracter.Count?length : caracter.Count;
                caracter.RemoveRange(0 , caracter.IndexOf(s[i])+1);
            }
            caracter.Add(s[i]);
        }
        return length > caracter.Count?length : caracter.Count;
    }
}
