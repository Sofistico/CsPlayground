// See https://aka.ms/new-console-template for more information
string[] strs = new string[]{
    "eat",
    "ate"
};
var expectedOutput = new List<IList<string>>{
new List<string>() {"eat, ate"}
};

var res = GroupAnagram.Group(strs);

if(res == expectedOutput)
    System.Console.WriteLine("Equal");
else
    System.Console.WriteLine("Not equal");