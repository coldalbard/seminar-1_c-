// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




// Console.Write("Please, enter the length of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] CreateArray(int size)                               
// {
//     int[] arr = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }

//Функция для создания массива



// int[] arr = CreateArray(size);

// void PrintArray(int size, int[] arr)
// {   
//     Console.Write("[");
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
// PrintArray(size, arr);

//Функция для вывода массива на экран



// int Even(int size, int[] arr)
// {
//     int even = 0;
//     for(int i = 0; i < size; i++)
//     {
//         if(arr[i] % 2 == 0)
//         {
//             even += 1;
//         }
//     }
//     return even;
// }

//Функция для подсчета количества четных чисел



// int Odd(int size, int[] arr)
// {
//     int odd = 0;
//     for(int i = 0; i < size; i++)
//     {
//         if(arr[i] % 2 != 0)
//         {
//             odd += 1;
//         }
//     }
//     return odd;
// }

//Функция для подсчета количества нечетных чисел(надеюсь за инициативу не побьют))



// int res1 = Even(size, arr);
// int res2 = Odd(size, arr);
// Console.WriteLine($"The number of even numbers in the array = {res1}. \nThe number of odd numbers in the array = {res2}.");
















// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// Console.Write("Please, enter the length of the array: ");
// int length = Convert.ToInt32(Console.ReadLine());

// int[] Array(int length)                               
// {
//     int[] arr = new int [length];
//     for(int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(-100, 100);
//     }
//     return arr;
// }

// //Функция для создания массива

// int[] array = Array(length);



// void PrintArray(int length, int[] array)
// {   
//     Console.Write("[");
//     for(int i = 0; i < length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
// PrintArray(length, array);

// //Функция для вывода массива на экран




// int Odd_index(int length, int[] array)
// {
//     int odd = 0;
//     for(int i = 0; i < length; i++)
//     {
//         if(i % 2 != 0)
//         {
//             odd += array[i];
//         }
//     }
//     return odd;
// }
// int result = Odd_index(length, array);

// //сумма элементов, стоящих на нечётных позициях.




// int Even_index(int length, int[] array)
// {
//     int even = 0;
//     for(int i = 0; i < length; i++)
//     {
//         if(i % 2 == 0)
//         {
//             even += array[i];
//         }
//     }
//     return even;
// }
// int result1 = Even_index(length, array);

// //сумма элементов, стоящих на четных позициях.


// Console.WriteLine($"The sum of the elements standing in even positions = {result1}. \nThe sum of the elements in odd positions = {result}");














// Console.Write("Please, enter the length of the array: ");
// int number = Convert.ToInt32(Console.ReadLine());



// int[] Array(int number)                               
// {
//     int[] massiv = new int [number];
//     for(int i = 0; i < number; i++)
//     {
//         massiv[i] = new Random().Next(1, 100);
//     }
//     return massiv;
// }

// //Функция для создания массива

// int[] massiv = Array(number);





// void PrintArray(int number, int[] massiv)
// {
//     Console.Write("[");
//     for(int i = 0; i < number; i++)
//     {
//         Console.Write($"{massiv[i]}, ");
//     }
//     Console.WriteLine("]");
// }
// PrintArray(number, massiv);

// //Функция для вывода массива на экран




// int Min(int number, int[] massiv)
// {
//     int min = 0;
//     for(int i = 0; i < number; i++)
//     {
//         if(min > massiv[i])
//         {
//             min = massiv[i];
//         }
//     }
//     return min;
// }
// int min = Min(number, massiv);
// Console.WriteLine(min);

// //Функция для нахождения минимального элемента массива




// int Max(int number, int[] massiv)
// {
//     int max = 0;
//     for(int i = 0; i < number; i++)
//     {
//         if(max < massiv[i])
//         {
//             max = massiv[i];
//         }
//     }
//     return max; 
// }
// int max = Max(number, massiv);
// Console.WriteLine(max);

// //Функция для нахождения максимального элемента в массиве

// Console.WriteLine($"{max} - {min} = {max - min}");



