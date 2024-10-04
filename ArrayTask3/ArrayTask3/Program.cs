//Arrayin elementlerinden uzunlugu 4den cox olanlari tapin
string[] arr = { "Mehin", "Rahimli", "BP","217","Code","Academy" };
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length > 4)
    {
        Console.WriteLine(arr[i]);
    }

}