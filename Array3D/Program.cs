// int val = 1; // Fill the array with values starting from 1
// int[,,] array3D = new int[2, 3, 4];

// for (int i = 0; i < 2; i++)
// {
//     Console.Write($"Block {i + 1}:\n");
//     for (int j = 0; j < 3; j++)
//     {
//         for (int k = 0; k < 4; k++)
//         {
//             array3D[i, j, k] = val++;
//             Console.Write($"{array3D[i, j, k],3} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
Console.Write("Enter a value to search in the 3D array:");
int val = Convert.ToInt32(Console.ReadLine()); // Value to search for in the 3D array
Console.WriteLine($"Searching for value: {val}...");
Thread.Sleep(9000); // Simulate a delay for better user experience
bool found = false;
int[,,] array3D = new int[3, 2, 2]
{
    { { 1, 2 }, { 3, 4 } },
    { { 5, 6 }, { 7, 8 } },
    { { 9, 10 }, { 11, 12 } }
};
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            if (array3D[i, j, k] == val)
            {
                found = true;
                Console.WriteLine($"Value \"{val}\" found at indices [{i}, {j}, {k}]");
                break;
            }
        }
        if (found) break;
    }
    if (found) break;
}