Console.Clear();
int [] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int x = array.Length;
int find = 18;

int index = 0;

while(index < x)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}