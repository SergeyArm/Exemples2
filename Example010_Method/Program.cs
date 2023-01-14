int[] array = {21, 12, 43, 810 ,65, 688, 87, 38, 839, 810};

int n = array.Length;

int find = 810;

int index = 0;
while (index<n)
{
    if(array[index] == find)
    {Console.WriteLine(index);
    break;
    }
    index++;
}