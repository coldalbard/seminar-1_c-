// Написать программу, которая обменивает 
// элементы любых двух строк массива

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
//Функцмя для заполнения массива

// void ShowArray(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Функция для вывода массива на экран

// int[,] ChangeArrayRows(int[,] matrix)
// {
//     Console.Write("Enter number of first row: ");
//     int row1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter number of second row: ");
//     int row2 = Convert.ToInt32(Console.ReadLine());
//     if(row1 >= 0 && row2 >= 0 
//     && row1 < matrix.GetLength(0) 
//     && row2 < matrix.GetLength(0)
//     &&row1 != row2){
//         for(int i = 0; i < matrix.GetLength(1); i++){
//             int temp = matrix[row1, i];
//             matrix[row1, i] = matrix[row2, i];
//             matrix[row2, i] = temp;
//         }
//         return matrix;
//     }
//     else{
//         Console.WriteLine("incorrect input");
//         ChangeArrayRows(matrix);
//         return matrix;
//     }
// }
// // Функция для замены двух обмена строк введенных пользователем

// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("min = ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max = ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = CreateArray(m, n, min, max);

// ShowArray(matrix);

// matrix = ChangeArrayRows(matrix);

// ShowArray(matrix);





// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).


// void ArrayReverse(int[,] matrix)
// {
//     if(matrix.GetLength(0) == matrix.GetLength(1) 
//     && matrix.GetLength(0) > 0 
//     && matrix.GetLength(1) > 0)
//     {
//         for(int i = 0; i < matrix.GetLength(0); i++) 
//         {
//             for(int j = i + 1; j < matrix.GetLength(1); j++) 
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = temp;
//             }
//         }
//         ShowArray(matrix);
//     }
//     else
//     {
//         Console.WriteLine("Error, the array is not square.");
//     }
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

// ShowArray(matrix);

// ArrayReverse(matrix);

// matrix = ChangeArrayRows(matrix);

// ShowArray(matrix);



// Напишите программу, которая 

// void Replacement(int[,] matrix)
// {
//     int imin = 0, jmin = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             if(matrix[i, j] < matrix[imin, jmin])
//             {
//                 imin = i;
//                 jmin = j;
//                 matrix[imin, jmin] = matrix[i, j];
//                 matrix[i, j] = 0;
//             }
//         }
//     }

//     for(int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             matrix[i, jmin] = 0;
//             matrix[imin, j] = 0;
//         }
//     }
//     ShowArray(matrix);
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

// ShowArray(matrix);

// Replacement(matrix);

