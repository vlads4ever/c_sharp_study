int[] array = {1, 12, 43, 4, 63, 37, 4, 3, 6};

int n = array.Length;       //Получить количество элементов массива
int find =4;                //Элемент, который нужно найти

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;              //Остановить поиск после первого нахождения       
    }
    index++;
}