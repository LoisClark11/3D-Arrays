/*//---------------------Looping through an empty 3D array---------------------
int value = 1; // Fill the array with valueues starting from 1
int[,,] array3D = new int[2, 3, 4];

for (int i = 0; i < 2; i++)
{
    Console.Write($"Block {i + 1}:\n");
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            array3D[i, j, k] = value++;
            Console.Write($"{array3D[i, j, k],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/
// --------------User input to search for a value in the 3D array---------------------

int[,,] array3D = new int[3, 2, 2]
{
    { { 1, 2 }, { 3, 4 } },
    { { 5, 6 }, { 7, 8 } },
    { { 9, 10 }, { 11, 12 } }
};

for (int i = 0; i < array3D.GetLength(0); i++)
{
    Console.Write($"Block {i + 1}:\n");
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            Console.Write($"{array3D[i, j, k],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter a value to search in the 3D array:");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Searching for value: {value}...");
Thread.Sleep(4000);
bool found = false;

for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            if (array3D[i, j, k] == value)
            {
                found = true;
                Console.WriteLine($"The value \"{value}\" found at indices [{i}, {j}, {k}]");
                break;
            }
        }
        if (found) break;
    }
    if (found) break;
}
//----------------------Looping through a predefined 3D array----------------------
//int[,,] array3D = new int[2, 3, 4]
//{
//    { { 1, 2, 9, 10 }, { 3, 4, 11, 12 }, { 17, 18, 19, 20 } },
//    { { 5, 6, 13, 14 }, { 7, 8, 15, 16 }, { 21, 22, 23, 24 } }
//};
//for (int i = 0; i < array3D.GetLength(0); i++)
//{
//    for (int j = 0; j < array3D.GetLength(1); j++)
//    {
//        for (int k = 0; k < array3D.GetLength(2); k++)
//        {
//            Console.Write($"{array3D[i, j, k],3} ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}