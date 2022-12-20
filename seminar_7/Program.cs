// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// // Функция для создания двумерного массива



// int[,] arr = CreateArray(m, n);
// // присваиваем переменной arr массив из прошлой функции




// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// PrintArray(arr);

// Функция для вывода массива на экран





// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// int[,] Amn(int[,] arr)
// {
//     int[,] array = new int [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// int[,] res = Amn(arr);
// PrintArray(res);





// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// int[,] FillArray(int[,] arr)
// {
//     int[,] array = new int [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = arr[i, j] * arr[i ,j];
//             }
//             else
//             {
//                 array[i, j] = arr[i, j];
//             }
//         }
//     }
//     return array;
// }
// int[,] arrayNew = FillArray(arr);
// PrintArray(arrayNew);


// Задайте двумерный массив. 
// Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int NewArray(int[,] arr)
// {
//     int[,] array = new int [m, n];
//     int count = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 count += arr[i, j];
//             }
//         }
//     }
//     return count;
// }
// int res = NewArray(arr);
// Console.Write($"Сумма элементов главной диагонали: {res}");