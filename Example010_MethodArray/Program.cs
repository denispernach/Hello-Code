int [] array = {1, 22, 35, 24, 35, 356, 77, 38};
int n = array.Length;
int find = 35;
int index = 0;
while (index < n)
{
if (array [index] == find)
{
    Console.WriteLine (index);
    break;
}
index = index+1;
}