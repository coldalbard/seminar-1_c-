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

// //Функция для создания массива



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

// //Функция для вывода массива на экран



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

// //Функция для подсчета количества четных чисел



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

// //Функция для подсчета количества нечетных чисел(надеюсь за инициативу не побьют))



// int res1 = Even(size, arr);
// int res2 = Odd(size, arr);
// Console.WriteLine($"The number of even numbers in the array = {res1}. \nThe number of odd numbers in the array = {res2}.");












// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int size = 123;

// int[] CreateArray(int size)                               
// {
//     int[] arr = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-123, 1000);
//     }
//     return arr;
// }

// //Функция для создания массива



// int[] arr = CreateArray(size);

// void PrintArray(int size, int[] arr)
// {   
//     Console.Write("[");
//     for(int i = 0; i < size; i++)
//     {
//         if(arr[i] < 10 || arr[i] > 99)
//         {
//         Console.Write($"{arr[i]}, ");
//         }
//         else if(arr[i] > 10 && arr[i] < 99)
//         {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.Write($"{arr[i]}, ");
//         Console.ForegroundColor = ConsoleColor.White;
//         }
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
// PrintArray(size, arr);

// //Функция для вывода массива на экран с выделением для чисел которые arr[i]> 10, arr[i] < 99;




// void Comparison(int[] arr)
// {
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 10 && arr[i] < 99)
//         {
//             count = count + 1;
//         }

//     }
//     Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
// }
// Comparison(arr);

// //Функция ждя подсчета элементов которые находятся между 10 и 99.

















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












// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Please, enter the length of the array: ");
// int number = Convert.ToInt32(Console.ReadLine());



// double[] Array(int number)                               
// {
//     double[] massiv = new double [number];
//     for(int i = 0; i < number; i++)
//     {
//         massiv[i] = Convert.ToDouble(new Random().Next(1000, 10000)) / 100;
//     }
//     return massiv;
// }

// //Функция для создания массива

// double[] massiv = Array(number);





// void PrintArray(int number, double[] massiv)
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




// double Min(double[] massiv)
// {
//     double min = massiv[0];
//     for(int i = 0; i < massiv.Length; i++)
//     {
//         if(min > massiv[i])
//         {
//             min = massiv[i];
//         }
//     }
//     return min;
// }
// double min = Min(massiv);

// //Функция для нахождения минимального элемента массива




// double Max(double[] massiv)
// {
//     double max = massiv[0];
//     for(int i = 0; i < massiv.Length; i++)
//     {
//         if(max < massiv[i])
//         {
//             max = massiv[i];
//         }
//     }
//     return max; 
// }
// double max = Max(massiv);

// //Функция для нахождения максимального элемента в массиве

// Console.WriteLine($"min = {min} \nmax = {max}");
// Console.WriteLine($"{max} - {min} = {max - min}");





// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.Write("Please, enter the length of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] Array(int size)                               
// {
//     int[] massiv = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         massiv[i] = new Random().Next(1, 10);
//     }
//     return massiv;
// }

// //Функция для создания массива

// int[] massiv = Array(size);





// void PrintArray(int size, int[] massiv)
// {
//     Console.Write("[");
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"{massiv[i]}, ");
//     }
//     Console.WriteLine("]");
// }
// PrintArray(size, massiv);

// // Функция для вывода массива на экран




// int[] Nums(int[] massiv)
// {
//     for(int i = 0; i < massiv.Length; i++)
//     {
//         for(int j = massiv.Length - 1; j >= 1; j--)
//         {
//             massiv[i] = massiv[i] * massiv[j];
//             i++;
//         }
//     }

//     int[] arr = new int [massiv.Length / 2];

//     for(int f = 0; f < massiv.Length / 2; f++)
//     {
//         arr[f] = massiv[f];
//     }
//     return arr;

// }

//Функция для произведения пар чисел в одномерном массиве.





// void Print(int[] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("]");
// }
// Print(Nums(massiv));

// //Функция для вывода массива на экран

//Это первый метод(проблема в том, что я сначала развернул 
//массив а потом начал умножать. И я теперь не могу вывести 
//элемент который у нас находится по середине если длина нашего массива равна
// massiv.Length / 2 + 1, но спустя несколько часов  серфинга в инете я придумал
// второй метод, который работает как надо. Но этот метод тоже имеет право на
// существование, если даработать конечно).
//Мой код наверное не поймут даже индусы, извиняюсь если потратил ваше время))






// //2-й метод

// Console.Write("Please, enter the length of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] ArrayA(int size)
// {
//     int[] arr = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }

// int[] arr = ArrayA(size);

// //Функция для создания массива





// void Print(int[] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine("]");
// }
// Print(arr);

// //Функция для вывода массива на экран




// int[] KolVo(int size, int[] arr)
// {
//     int[] res1 = new int [size];

//     for(int i = 0; i < arr.Length; i++)
//     {
//         res1[i] = arr[(arr.Length - 1) - i] * arr[i];
//     }

//     int n = 0;

//     if(res1.Length % 2 == 0) 
//     {
//         n = res1.Length / 2;
//     }
//     else if(res1.Length % 2 != 0)
//     {
//         n = res1.Length / 2 + 1;
//     }

//     int[] res = new int [n];
//     for(int j = 0; j < n; j++)
//     {
//         res[j] = res1[j];
//         if(res1.Length % 2 != 0)
//         {
//             int temp = arr[n - 1];
//             arr[n - 1] = res[n - 1];
//             res[n - 1] = temp;
//         }
//     }
//     return res;
    
// }
// int[] result = KolVo(size, arr);

// //Функция для произведения пар чисел в одномерном массиве.






// Print(result);