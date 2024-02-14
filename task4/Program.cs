

int n = Convert.ToInt32(Console.ReadLine());

int []nums = new int[n];
int smd =0;
int j = 0;
for (int i = 0; i < n; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());

  for(int j=0;j<n;j++)
 {
    if (nums[i] == j)
     System.Console.WriteLine(j);
  
 }


}

