string str = "3,5,6,8,0,-34";
string[] strArray = str.Split(',');

PositiveNumbersCounter(strArray);

void PositiveNumbersCounter(string[] array)
{
    int counter=0;
    for (int i = 0; i < array.Length; i++)
    {
    if (Convert.ToInt32(array[i])>0) counter++;
    }
    Console.WriteLine($"Number of Positive elements in You Array is: {counter}");
}