
int n = Convert.ToInt32(Console.ReadLine());
int x;
int y;
bool a=true;
int[] nums = new int[n];
for (int i = 0; i < n; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n - 1; i++)
{
    if( (nums[i]>0 && nums[i+1]>0) || (nums[i]<0 && nums[i+1]<0) )
    {
        x=nums[i];
        y=nums[i+1];
        a=false;

    }

}
if(true==false) System.Console.WriteLine(x+" "+y);