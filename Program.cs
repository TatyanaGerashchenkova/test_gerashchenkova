
string[] ArrayToArrayOf3OrlessLetters(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            result[j] = str[i];
            j++;
        }
    }
    return result;
}
//write function for outtput massive of strings on the screen 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
string[] array = { "hello", "2", "world", ":-)" };
string[] result = ArrayToArrayOf3OrlessLetters(array);
PrintArray(result);

