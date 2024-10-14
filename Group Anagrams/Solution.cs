public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //Use dictionary because dictionary will add string to each key for we 
        Dictionary<string, List<string>> d = new Dictionary<string, List<string>>();

        for (int i= 0; i<strs.Length; i++){
            // Turn each word to a char array then sorting it 
            char [] chars = strs[i].ToCharArray();
            Array.Sort(chars);

            String s = new (chars);
            //If don't have this key yet, add this key
            if (!d.ContainsKey(s))
            d[s] = new List<string>();

            //Add this String to List
            d[s].Add(strs[i]);
        }
        // Print all the key with all the values inside each key.
        return d.Values.ToList<IList<string>>();
    }
}