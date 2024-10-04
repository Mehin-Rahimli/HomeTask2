//Ededlerden ibaret arrayin en kicik elementini tapin
int [] arr = { 999,992,993,993,994};
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine("Arrayin en kicik elementi: " + min);


