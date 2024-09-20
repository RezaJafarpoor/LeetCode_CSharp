// See https://aka.ms/new-console-template for more information

using LeetCodes.Easy;

var s = new ValidParentheses();
var dict = new Dictionary<int, int>();
dict[1] = 20;
var stack = new Stack<int>();
stack.Push(1);
Console.WriteLine(s.IsValid("[}"));
