int lenArray = ReadInt("Enter the length of the array:  ");
Console.Write("[ ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 100);
    Console.Write(randomArray[i] + ", ");
}
Console.Write("]");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
};