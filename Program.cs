static string[] InitArray(int size)
{
    string[] string_arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        string_arr[i] = Convert.ToString(Console.ReadLine());
    }
    return string_arr;
}

static void WriteArray(string[] array)
{
    string str_array = "";
    for (int i = 0; i < array.Length; i++)
    {
        str_array = str_array + " " + array[i];
    }
    Console.WriteLine(str_array);
    return;
}

static string[] CheckArray(string[] array, int str_size)
{
    string[] answer_arr = [];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < str_size)
        {
            Array.Resize(ref answer_arr, answer_arr.Length + 1);
            answer_arr[answer_arr.Length - 1] = array[i];
        }
    }
    return answer_arr;
}

int str_size = 3;
int array_size = 5;
Console.WriteLine("Введите элементы массива начиная с новой строки:");
string[] array = InitArray(array_size);
Console.WriteLine("Исходный массив:");
WriteArray(array);
Console.WriteLine("Итоговый массив:");
WriteArray(CheckArray(array, str_size));
