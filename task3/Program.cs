int n = Convert.ToInt32(Console.ReadLine());



int []nums = new int[n];
int m = nums[0];
int j = 0;
for (int i = 0; i < n; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
 for(int i=0;i<n;i++)
 {
    if (nums[i] > m)
    m = nums[i];
    j = i;
 }
 System.Console.WriteLine(j);


