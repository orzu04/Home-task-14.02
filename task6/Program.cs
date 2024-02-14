


int n = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[n];
int smd = 0;
int j = 0;
for (int i = 0; i < n; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());




}
for (int i = 1; i < n - 1; i++)
{
    if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1]) 
    {
        smd++;
    }

}
System.Console.WriteLine(smd);




