int n = 10;
int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int i = 0;

while(i < n)
{
    if(array[i] % 10 == 0 )
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}