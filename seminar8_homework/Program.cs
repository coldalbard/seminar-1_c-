﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int [m, n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }
// // Функция для создания двумерного массива

// void PrintArray(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Функция для вывода двумерного массива в консоль

// int[,] Sort2DArray(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             for(int k = 0; k < matrix.GetLength(1); k++){
//                 if(matrix[i, j] >= matrix[i, k]){
//                     int temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return matrix;
// }
// Функция для сортировки массива по строкам(по убыванию)


// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("min = ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max = ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = CreateArray(m, n, min, max);

// PrintArray(matrix);

// int[,] arr = Sort2DArray(matrix);

// PrintArray(arr);





// // 1-й метод я нашел в интернете, в принципе я понял как он работает,
// // но он показалася мне сложным. Из-за этого я придумал свой метод, который 
// // будет по понятней и кароче)

// // 2-й метод

// int[,] Sort2DLinesArray(int[,] matrix)
// {
//     int[,] arr = new int [matrix.GetLength(0), matrix.GetLength(1)];
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             if(matrix[i, j] > matrix[i, j]){
//                 arr[i, j] = matrix[i, j];
//             }
//         }
//     }
//     return arr;
// }

// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("min = ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max = ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = CreateArray(m, n, min, max);

// PrintArray(matrix);

// int[,] arr = Sort2DLinesArray(matrix);

// PrintArray(arr);



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// int[] SumLines(int[,] matrix){
//     int[] result = new int [matrix.GetLength(0)];
//     for(int i = 0; i < matrix.GetLength(1); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             result[i] += matrix[i, j];
//         }
//     }
//     return result;
// }
// // Функция для сложения элементов строк

// void FillArray(int[] result){
//     int min = result[0];
//     int index = 0;
//     for(int i = 0; i < result.Length; i++){
//         Console.Write($"{i + 1} Line - {result[i]}; ");
//         Console.WriteLine();
//         if(min > result[i]){
//             min = result[i];
//             index = i;
//         }
//     }
//     Console.WriteLine($"with the smallest sum of elements line: {index + 1} - {min}");
// }
// // Функция для нахождения строки с минимальной суммой элементов 



// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("min = ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max = ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = CreateArray(m, n, min, max);
// PrintArray(matrix);

// int[] res = SumLines(matrix);
// FillArray(res);







// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] CreateArray2(int x, int y, int minValue, int maxValue){
//     int[,] array = new int [x, y];
//     for(int i = 0; i < x; i++){
//         for(int j = 0; j < y; j++){
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }
// // Функция для создания второго массива 


// int[,] SumMatrix(int[,] matrix, int [,] array){
//     int[,] sumMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             int sum = 0;
//             for (int k = 0; k < sumMatrix.GetLength(1); k++){
//                 sum += matrix[i,k] * array[k,j];
//             }
//             sumMatrix[i, j] = sum;
//         }
//     }

//     return sumMatrix;
// }




// Console.Write("Please enter the number of rows in the first array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in the first array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of rows in the second array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in the second array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the minimum value of the first array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the maximum value of the first array: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the minimum value of the second array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the maximum value of the second array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = CreateArray(m, n, min, max);
// PrintArray(matrix);

// int[,] array = CreateArray2(x, y, minValue, maxValue);
// PrintArray(array);

// int[,] sumMatrix = SumMatrix(matrix, array);
// PrintArray(sumMatrix);







// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DMatrix(int m, int n, int x){
//     int[,,] matrix3D = new int [m, n, x];
//     for (int i = 0; i < matrix3D.GetLength(0); i++){
//         for (int j = 0; j < matrix3D.GetLength(1); j++){
//             for (int k = 0; k < matrix3D.GetLength(2); k++){
//                 matrix3D[i, j, k] = new Random().Next(1, 10);
//             }
//         }
//     }
//     return matrix3D;
// }

// void Print3DMatrix(int[,,] matrix3D){
//     for (int i = 0; i < matrix3D.GetLength(0); i++){
//         for (int j = 0; j < matrix3D.GetLength(1); j++){
//             for (int k = 0; k < matrix3D.GetLength(2); k++){
//                 Console.Write($"{matrix3D[i, j, k]} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] Replacement(int[,,] matrix3D){
//     int[] array = new int [matrix3D.GetLength(0) *  matrix3D.GetLength(1) * matrix3D.GetLength(2)];
//     for (int i = 0; i < matrix3D.GetLength(0); i++){
//         for (int j = 0; j < matrix3D.GetLength(1); j++){
//             for (int k = 0; k < matrix3D.GetLength(2); k++){

//             }
//         }
//     }
//     return matrix3D;
// }


    
// Console.Write("Please enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix3D = Create3DMatrix(m, n, x);
// Print3DMatrix(matrix3D);
// Console.WriteLine();

// int[,,] array = Replacement(matrix3D);
// Print3DMatrix(array);
