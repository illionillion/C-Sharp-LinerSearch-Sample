// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[] arr = new int[] {30,21,42,12,3,77,65,3};

int find = 3;

for (int i = 0; i < arr.Length; i++)
{
    if (find==arr[i])
    {
        Console.WriteLine(i+"番目にあります");
    }
}