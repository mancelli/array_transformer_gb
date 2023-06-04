Console.Clear();
Console.WriteLine("Введите строку для добавления в массив");

string[] initArray = new string[10];
int count = 0;
for(count = 0; count<initArray.Length; count++)
{
    initArray[count] = Console.ReadLine();
    if (initArray[count] == String.Empty)
    {
        break;
    }
    System.Console.WriteLine("Введите следующую строку, либо нажмите ENTER чтобы завершить ввод");
}

