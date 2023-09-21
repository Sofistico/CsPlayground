// See https://aka.ms/new-console-template for more information
string[] strs = new string[]{
"eat","tea","tan","ate","nat","bat"};
var expectedOutput = new List<IList<string>>{
new List<string>(){"bat"},new List<string>(){"nat","tan"},new List<string>(){"ate","eat","tea"}
};

var res = GroupAnagram.Group(strs);

if(res == expectedOutput)
    System.Console.WriteLine("Equal");
else
    System.Console.WriteLine("Not equal");