// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.

string[] FirstArray = {"dfghdkbfv", "2fsgbgb", "ffb", "sbsdfb", "44", "2fsgbgb", "ffb", "sbsdfb", "44"};
string[] SecondArray = new string[FirstArray.Length];
void FillArray(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(FirstArray, SecondArray);
PrintArray(SecondArray);