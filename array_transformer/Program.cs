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
string[] actualArray = new string[count];
int shortCount = 0;
for (count = 0; count<actualArray.Length; count++)
{
    actualArray[count] = initArray[count];
    if(actualArray[count].Length<4)
    {
        shortCount++;
    } 
}
string[] result = new string[shortCount];
shortCount = 0;
for (count = 0; count<actualArray.Length; count++)
{
    if(actualArray[count].Length<4)
    {
        result[shortCount] = actualArray[count];
        System.Console.WriteLine(result[shortCount]);
        shortCount++;
    } 
}
