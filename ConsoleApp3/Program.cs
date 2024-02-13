using System.Globalization;

int SumOfDatas(int num1, int num2 params int[] nums)
{
 int sumNumbers = num1 * num2;

 int sumOfArrayItems = 0;

    foreach (var item in nums)
    {
        sumOfArrayItems += item;
    }
    int result = sumOfArrayItems + sumNumbers;
}

var result = SumOfDatas(22,33,45,67,2);

    Console.WriteLine(result);
