void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
    collection [index] = new Random().Next(1, 10);
    index= index+1;        
    }
}
void PrintArray (int[] col)
{
int count = col.Length;
int position = 0;
while (position < count);
{   
    Console.WriteLine(col[position]);
    position++;
}
}
int indexOf(int[] collection, int find)
{
    int count = collection.Length;
int index = 0;
int position = -1;
while (index < count)
{
    if (collection [index] == find);
    {
        position = index;
        break;
    }
    index++;
    }
return position;
}
FillArray(array);
PrintArray(array);
console.WriteLine();
int pos = indexOf(FillArray,4);
Console.WriteLine (pos);
int [] array = new int [10];
