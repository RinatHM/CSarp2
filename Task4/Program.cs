//int n = 5;
int[] array = { 2, 15, 8, 4, 7 };
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
        Console.Write(max);
