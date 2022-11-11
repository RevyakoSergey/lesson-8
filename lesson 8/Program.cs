 //Задача 54
 /*Console.Write("введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Рандомный массив: ");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) ; j++)
 {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
    {
        if (numbers[i, z] < numbers[i, z + 1]) 
          {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
       }
         }
 }
}
Console.WriteLine();
Console.WriteLine("Массив с элементами по убыванию:");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t" );
        }
       
       Console.WriteLine(" ");
    }
}
*/
//Задача 56 
/*
Console.Write("введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
RandomNumbers(numbers);
int minsum = Int32.MaxValue;
int xstring = 0;

Console.WriteLine();
PrintArray(numbers);

void RandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
 {
 array[i, j] = new Random().Next(0, 10);
  }
}
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++)
 {
     Console.Write($"{array[i, j]} \t ");
            
 }
        Console.WriteLine(" ");
 
 
 {
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
    xstring++;
    
}
 }
}  

    Console.Write($"Строка с наименьшей суммой элементов находится на  позиции  {xstring} и имеет сумму { minsum } \t ");
   Console.Write(" ");
}
*/

//Задача 58
/*
void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
 {
   for (int j = 0; j < array.GetLength(1); j++)
    {
            array[i, j] = new Random().Next(1, 10); 
       }
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
  for (int j = 0; j < array.GetLength(1); j++)
  {
            Console.Write($"{array[i, j]}\t");
    }
        
             Console.WriteLine("");
 }
}

int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];
ArrayRandomNumbers(matrix1);
ArrayRandomNumbers(matrix2);
int[,] matrix3 = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица-1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица-2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц ");
PrintArray(matrix3);
*/

//Задача 60
/*
int a1 = InputInt("Введите размер 1: ");
int a2 = InputInt("Введите размер 2: ");
int a3 = InputInt("Введите размер 3: ");
int countNums = 89;

if (a1 * a2 * a3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(a1, a2, a3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
 return int.Parse(Console.ReadLine());
}
*/
//Задача 62
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        //Console.Write("]");
        Console.WriteLine("");
    }
}
*/