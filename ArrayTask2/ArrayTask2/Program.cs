//Arrayin elementlerinin cemini tapin.
int[] numbers = { 1, 2, 30, 40 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);