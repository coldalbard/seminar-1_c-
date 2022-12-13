//Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int size = 12;
// int minValue = -9;
// int maxValue = 9;
// int [] array = CreateArray(size, minValue, maxValue);



// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// int FindPogSumm(int[] array)
// {
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             summ += array[i];
//         }
//     }
//     return summ;
// }
// int FindNegSumm(int[] array)
// {
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             summ += array[i];
//         }
//     }
//     return summ;
// }
// ShowArray(array);
// Console.WriteLine($"Summ of positive numbers is {FindPogSumm(array)}");
// Console.WriteLine($"Summ of negative numbers is {FindNegSumm(array)}");




// 1. Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите мин значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите мах знач: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());





// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// int [] array = CreateArray(size, minValue, maxValue);


// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }
// ShowArray(array);

// void Replacement(int[] array)
// {
//     int[] rev = new int [array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         rev[i] = array[i] * (-1);
//         Console.Write($"{rev[i]}, ");
//     }
// }
// Replacement(array);






// // 2. Задайте массив. Напишите программу, которая определяет, присутствует ли 
// // заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да


// bool Number(int[] array)
// {   
//     bool flag = false;
//     Console.Write("Please enter a number: ");
//     int numb = Convert.ToInt32(Console.ReadLine());
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == numb)
//         {
//             flag = true;
//             break;
//         }
//     }
//     return flag;
// }
// bool flag = Number(array);
// if(flag) Console.WriteLine("Yes");
// else Console.WriteLine("No");

