Console.WriteLine("Input matrix size: ");
int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

int firstD = matrix.GetLength(0);
int secondD = matrix.GetLength(1);

for (int i = 0; i < firstD; i++)
{
    for (int j = 0; j < secondD; j++)
    {
        int input = int.Parse(Console.ReadLine());
        matrix[i, j] = input;
    }
}

if (size == 2)
{
    int det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    Console.WriteLine(det);
}
else if (size == 3)
{
    int det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
              matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) -
              matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        
    Console.WriteLine(det);
}
else
{
    Console.WriteLine("Note implemented yet");
}


 for (int i = 0; i < firstD; i++)
 {
     for (int j = 0; j < secondD; j++)
     {
         Console.WriteLine($"[{i}, {j}]" + matrix[i,j]);
     }
 }


//A =    a b c
//       d e f
//       g h i

//       00 01 02
//       10 11 12
//       20 21 22

//|A| = a*(e*i − f*h) − b * (d * i − f* g) +c * (d * h − e* g)
// 00(11*22 - 12*21) - 01(10*22-12*20) - 02(10*21-11*20)