// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[] arr = new int[] {30,21,42,12,3,77,3,10,65,3};

Console.Write("探索する数値を入力>>>");
// int find = 3;
int find =int.Parse(Console.ReadLine());

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (find==arr[i])
    {
        Console.WriteLine(i+"番目にあります");
        count++;
    }
}
Console.WriteLine(count + "個見つかりました");