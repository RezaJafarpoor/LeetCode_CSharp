// See https://aka.ms/new-console-template for more information

using LeetCodes.Easy;

var array = new int[] { 1, 2, 3, 4, 5 };
var target = 7;
var t = new TwoSumProblem();
var result = t.TwoSum(array, target);
foreach (var VARIABLE in result)
{
    Console.WriteLine(VARIABLE);
}