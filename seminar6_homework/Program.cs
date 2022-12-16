// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 
// 1, -7, 567, 89, 223-> 3
// Console.Write("Please, enter the length of the array:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] CreateArray(int m){int[] arr = new int[m];
//     for(int i = 0; i < m; i++){Console.Write($"Please, enter the number under the index {i}: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }
// int[] arr = CreateArray(m);

// void PrinArray(int[] arr){
//     for(int i = 0; i < arr.Length; i++){Console.Write($"{arr[i]}, ");
//     }
// }
// PrinArray(arr);

// void Count(int[] arr){int count = 0;
//     for(int i = 0; i < arr.Length; i++){if(arr[i] > 0){count++;
//     }
//     }
//     Console.Write($"-> {count}");
// }
// Count(arr);
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Write("k1 =");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("k2 =");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b1 =");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b2 =");
// double b2 = Convert.ToDouble(Console.ReadLine());
// double x = -(b1 - b2) / (k1 - k2);
// double y = (k1 * x) + b1;
// Console.WriteLine($"({x}; {y})");