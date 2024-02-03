//int n = 10;
int[] array = { 2, 5, 8, 4, 7, 9, 35, 67, 88, 3 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
