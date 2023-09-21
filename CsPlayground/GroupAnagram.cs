public static class GroupAnagram{
    public static List<IList<string>> Group(string[] strs){
        List<IList<string>> result = new();
        Dictionary<string, List<string>> map = new();
        for (int i = 0; i < strs.Length; i++)
        {
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var str = chars.ToString();
            if(!map.ContainsKey(str)){
                map.Add(str, new List<string>() {strs[i]} );
            }
            else{
                map[str].Add(strs[i]);
            }
        }
        foreach(var res in map){
            result.Add(res.Value);
        }

        return result;
    }
}