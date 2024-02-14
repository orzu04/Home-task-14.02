


int sum =1;

int n = Convert.ToInt32(Console.ReadLine());
int[]arr = new int[n];
for(int i = 0;i<n;i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
      sum*=arr[i];
}

for(int i = 0;i<n;i++)
{
    System.Console.Write($"{arr[i]}*");
}

System.Console.WriteLine($" = {sum}");