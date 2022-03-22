// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int tiny=0;
int i,j;
int[] a = new int[5]{6,7,8,9,10};
int[] b = new int[5]{10,9,8,7,6};
Console.WriteLine(Solution(a,b,706));
int Solution(int[] a,int[] b, int k){
    for(i=0;i<a.Length;i++)
    {
        Console.WriteLine(String.Concat(a[i].ToString(),b[a.Length - (i+1)]));
        j = Convert.ToInt32(String.Concat(a[i].ToString(),b[a.Length - (i+1)])) <= k ? tiny++ : tiny;   
    }
    return tiny;
}

