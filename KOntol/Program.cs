string[] FillingFrrayOfStrings(int size)
{
    string[] arrayString = new string[size];
    for(int i=0;i<size;i++)
    {
        Console.Write("Enter the value of the array element: ");
        arrayString[i]= Convert.ToString(Console.ReadLine());
    }
    return arrayString;
}

