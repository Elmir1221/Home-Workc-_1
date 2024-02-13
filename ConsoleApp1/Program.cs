int SumOfEvenNumbs(int[] elems, int number)
{
    int sum = 0;

    foreach(var item in elems)
    {
        if (item % 2 == 0)
        {

            sum += item;
        
        
        
        }


    }
    int result = sum + number;

    return result; 

}

int[] nums = { 2, 45, 67, 88, 66, 24, 34, 33, };

Console.WriteLine(SumOfEvenNumbs(nums,5)); 