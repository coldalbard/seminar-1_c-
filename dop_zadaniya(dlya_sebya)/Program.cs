// Упражнение 1
// Напишите консольную программу, в которую пользователь вводит с клавиатуры 
// два числа. А программа сранивает два введенных числа и выводит на консоль 
// результат сравнения 
// (два числа равны, первое число больше второго или первое число меньше второго).

// Console.Write("Please, enter your number 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please, enter your number 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// void Comparison(int number1, int number2)
// {
//     if(number1 > number2)
//     {
//         Console.Write($"{number1} больше чем {number2}");
//     }
//     else if(number1 < number2)
//     {
//         Console.Write($"{number2} больше чем {number1}");
//     }
//     else if(number1 == number2)
//     {
//         Console.Write($"{number1} равен {number2}");
//     }
// }
// Comparison(number1, number2);






// Упражнение 2
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
// Если число одновременно больше 5 и меньше 10, то программа выводит 
// "Число больше 5 и меньше 10". 
// Иначе программа выводит сообщение "Неизвестное число".

// Console.Write("Please, enter your number: ");
// int number11 = Convert.ToInt32(Console.ReadLine());

// void Thegap(int number11)
// {
//     if(number11 > 5 && number11 < 10)
//     {
//         Console.Write("Число больше 5 и меньше 10");
//     }
//     else
//     {
//         Console.Write("Неизвестное число");
//     }
// }
// Thegap(number11);






// Упражнение 3
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
// Если число либо равно 5, либо равно 10, то программа выводит 
// "Число либо равно 5, либо равно 10". 
// Иначе программа выводит сообщение "Неизвестное число".

// Console.Write("Please, enter your number: ");
// int numb = Convert.ToInt32(Console.ReadLine());

// void Equal_numbers(int numb)
// {
//     if(numb == 5 || numb == 10)
//     {
//         Console.Write("Число либо равно 5, либо равно 10");
//     }
//     else
//     {
//         Console.Write("Неизвестное число");
//     }
// }
// Equal_numbers(numb);






// Упражнение 4
// В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
// Напишите консольную программу, в которую пользователь вводит сумму вклада. 
// Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, 
// то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. 
// В конце программа должна выводить сумму вклада с начисленными процентами.


// Console.Write("Please, enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int Bank(int num)
// {
//     int sum = 0;
//     if(num < 100)
//     {
//         sum = num + (num * 5 / 100);
//         return sum;
//     }
//     else if(num > 100 && num <= 200)
//     {
//         sum = num + (num * 7 / 100);
//         return sum;
//     }
//     else 
//     {
//         sum = num + (num * 10 / 100);
//         return sum;
//     }
// }
// int gh = Bank(num);
// Console.Write($"Your deposit amount = {num}. \nYour deposit amount including accrued interest = {gh}");





// Упражнение 5
// Изменим предыдущую задачу. 
// Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
// И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц 
// вне зависимости от их суммы. 
// Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.


// Console.Write("Please, enter your number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void Bank(int n)
// {
//     int sum1 = 0;
//     int sum2 = 0;
//     if(n < 100)
//     {
//         sum1 = n + (n * 5 / 100);
//         sum2 = sum1 + 15;
//         Console.WriteLine($"Your deposit amount = {n}.");
//         Console.WriteLine($"Your deposit amount including accrued interest = {sum1}.");
//         Console.WriteLine($"Your deposit amount including accrued interest and up to numerical bonuses = {sum2}");

//     }
//     else if(n > 100 && n <= 200)
//     {
//         sum1 = n + (n * 7 / 100);
//         sum2 = sum1 + 15;
//         Console.WriteLine($"Your deposit amount = {n}.");
//         Console.WriteLine($"Your deposit amount including accrued interest = {sum1}.");
//         Console.WriteLine($"Your deposit amount including accrued interest and up to numerical bonuses = {sum2}");
//     }
//     else 
//     {
//         sum1 = n + (n * 10 / 100);
//         sum2 = sum1 + 15;
//         Console.WriteLine($"Your deposit amount = {n}.");
//         Console.WriteLine($"Your deposit amount including accrued interest = {sum1}.");
//         Console.WriteLine($"Your deposit amount including accrued interest and up to numerical bonuses = {sum2}");
//     }
// }
// Bank(n);






// Упражнение 6
// Калькулятор для +-*/

// Console.Write("Please enter the first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the operation I remind you that: \n1. Addition is (+) \n2. Subtraction is (-) \n3. Multiplication is (*) \n4. Division is (/) \nEnter the operation: ");
// string oper = Console.ReadLine();
// Console.Write("Please enter the second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int Operations(int number1, string oper, int number2)
// {
//     int sum = 0;
//     if(oper == "1" || oper == "+")
//     {
//         sum = number1 + number2;
//         return sum;
//     }
//     else if(oper == "2" || oper == "-" || oper == "-")
//     {
//         sum = number1 - number2;
//         return sum;
//     }
//     else if(oper == "3" || oper == "*")
//     {
//         sum = number1 * number2;
//         return sum;
//     }
//     else if(oper == "4" || oper == "/")
//     {
//         sum = number1 / number2;
//         return sum;
//     }
//     else
//     {
//         return 0000;
//     }
// }
// int result = Operations(number1, oper, number2);
// void PrintResult(int result)
// {
//     if(result == 0000)
// {
//     Console.Write("Error, check if you have written the numbers or operations correctly");
// }
// else
// {
//     Console.Write($"{number1} {oper} {number2} = {result}");
// }
// }
// PrintResult(result);





















// Циклы






// Упражнение 1
// За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
// Напишите консольную программу, в которую пользователь вводит сумму вклада 
// и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления 
// процентов за каждый месяц.


// Console.Write("Please enter the deposit amount: ");
// int deposit = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of months: ");
// int numbers = Convert.ToInt32(Console.ReadLine());

// int Accruals(int deposit, int numbers)
// {
//     int numbers1 = deposit;
//     for(int i = 0; i <= numbers; i++)
//     {
//         numbers1 += (deposit * 7 / 100);
//     }
//     return numbers1;

// }
// int res = Accruals(deposit, numbers);
// Console.Write($"После {numbers} месяцев сумма вклада составит {res}");




// Упражнение 2
// Перепишите предыдущую программу, 
// только вместо цикла for используйте цикл while.

// Console.Write("Please enter the deposit amount: ");
// int deposit = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of months: ");
// int numbers = Convert.ToInt32(Console.ReadLine());

// int Accruals(int deposit, int numbers)
// {
//     int numbers1 = deposit;
//     int i = 0;
//     while(i <= numbers)
//     {
//         numbers1 += (deposit * 7 / 100);
//         i++;
//     }
//     return numbers1;
// }
// int res = Accruals(deposit, numbers);
// Console.Write($"После {numbers} месяцев сумма вклада составит {res}");




// Упражнение 3
// Напишите программу, которая выводит на консоль таблицу умножения

// Console.Write("Enter the number you would like to see the multiplication table to ten: ");
// int theNumber = Convert.ToInt32(Console.ReadLine());

// void MultiplicationTables(int theNumber)
// {
//     int res = 0;
//     for(int i = 1; i <= 10; i++)
//     {
//         res = theNumber * i;
//         Console.WriteLine($"{theNumber} * {i} = {res}");
//     }
// }
// MultiplicationTables(theNumber);




// Упражнение 4
// Напишите программу, в которую пользователь вводит два числа и выводит результат
// их умножения. При этом программа должны запрашивать у пользователя ввод чисел, 
// пока оба вводимых числа не окажутся в диапазоне от 0 до 10. 
// Если введенные числа окажутся больше 10 или меньше 0, 
// то программа должна вывести пользователю о том, что введенные числа недопустимы,
// и повторно запросить у пользователя ввод двух чисел. 
// Если введенные числа принадлежат диапазону от 0 до 10, 
// то программа выводит результат умножения.

// Для организации ввода чисел используйте бесконечный цикл while и оператор break.


// Console.Write("Please enter the first number (which is greater than zero but less than ten):  ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the second number (which is greater than zero but less than ten):  ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// void Multiplication(int firstNumber, int secondNumber)
// {
//     while(true)
//     {
//     if(firstNumber < 0 || firstNumber > 10 && secondNumber < 0 || secondNumber > 10)
//     {
//         Console.Write("Error");
//     }
//     else
//     {
//     Console.Write($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
//     break;
//     }
//     }
// }
// Multiplication(firstNumber, secondNumber);





// Задачи с массивами

// Количество положительных чисел
// Найдем количество положительных чисел в массиве:

// int[] array = {-4, -3, -2, -1, 0, 1, 2, 3, 4};
// int size = array.Length;

// void Array(int[] array)
// {
//     int res = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if(array[i] > 0)
//         {
//             res++;
            
//         }
//     }
//     Console.Write(res);
// }
// Array(array);





// Инверсия массива
// Вторая задача - инверсия массива, то есть переворот его в обратном порядке:
// Console.Write("Please, enter the length of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] Massiv(int size)
// {
//     int[] arr = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Please, enter the number under the index {i}: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void Revers(int[] arr)
// {
//     Console.Write("[");
//     for(int i = size - 1; i >= 0 ; i--)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("]");
// }
// Revers(Massiv(size));



// Программа сортировки массива
// Теперь возьмем задачу посложнее - простейшую сортировку массива:
// int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

// int[] Nums(int[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//     {
//         for(int j = 0; j < nums.Length - 1; j++)
//         {
//             if(nums[j] > nums[j + 1])
//             {
//                 int temp = nums[j + 1];
//                 nums[j + 1] = nums[j];
//                 nums[j] = temp;
//             }
//         }
//     }
//     return nums;
// }

// void Print(int[] nums)
// {
//     Console.Write("[");
//     for(int i = 0; i < nums.Length; i++)
//     {
//         Console.Write($"{nums[i]}, ");
//     }
//     Console.Write("]");
// }
// Print(Nums(nums));











// Знакомство с языками программирования (семинары)
// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// Console.Write("Please, enter the length of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[] CreateArray(int size)
// {
//     int[] arr = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Please enter the element under the index {i}: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();
//     }
//     return arr;
// }

// //Функция для создания массива с опр и с опр элементами которые вводит пользователь

// int[] arr = CreateArray(size);





// void PrintArray(int[] arr)
// {
//     Console.Write("Your numbers - [");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0)
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.Write($"{arr[i]}, ");
//             Console.ForegroundColor = ConsoleColor.White;
//         }
//         else if(arr[i] < 0)
//         {
//             Console.Write($"{arr[i]}, ");
//         }
//     }
//     Console.WriteLine("]");
//     Console.WriteLine();
// }
// PrintArray(arr);

// //Функция для вывода массива, в котором подсвечены зеленым числа котрые > 0;




// void More(int[] arr)
// {
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Numbers that are greater than zero - {count}");
//     Console.WriteLine();

// }

// More(arr);

// //Функция для подсчета полож чисел









// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




// int size = 2;

// double[] PointK(int size)
// {
//     double[] arr = new double [size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Please enter a period: k{i + 1} = ");
//         arr[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return arr;
// }
// double[] arr = PointK(size);

// //Функция для ввода точек k1, k2




// double[] PointB(int size)
// {
//     double[] array = new double [size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Please enter a period: b{i + 1} = ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;
// }
// double[] array = PointB(size);

// //Функция для ввода точек b1, b2




// void Intersection(double[] arr, double[] array)
// {
//     double num = -(array[0] - array[1]) / (arr[0] - arr[1]);
//     double num2 = arr[0] * num + array[0];
//     Console.Write($"Intersection at a point ({num}, {num2})");
// }
// Intersection(arr, array);

// //Функция для нахождения точек пересечения












// Двумерные массивы
// Показать двумерный массив размером m×n заполненный целыми числами

// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreatArray(int m, int n)
// {
//     int[,] array = new int [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// // Функция для создания двумерного массива


// int[,] arr = CreatArray(m, n);
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
// }
// PrintArray(arr);

// // Функция для вывода массива на экран












// Показать двумерный массив размером m×n заполненный вещественными числами

// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// double[,] FillArray(int x, int y)
// {
//     double[,] array = new double [x, y];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble() * 100;
//             array[i, j] = Math.Round(array[i , j], 2);
//         }
//     }
//     return array;
// }

// // Функция для создания двумерного массива с вещественными элементами

// double[,] arr = FillArray(x, y);
// // присваиваем переменной arr массив из прошлой функции

// void ReturnArray(double[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Функция для вывода массива на экран
// ReturnArray(arr);




// В двумерном массиве n×k заменить четные элементы на противоположные

// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreatArray2(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// // Функция для создания двумерного массива

// int[,] new_array = CreatArray2(m, n);
// // Присваеваем перемнной new_array массив из прошлой функции


// void PrintArray2(int[,] new_array)
// {
//     for(int i = 0; i < new_array.GetLength(0); i++)
//     {
//         for(int j = 0; j < new_array.GetLength(1); j++)
//         {
//             Console.Write($"{new_array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Функция для вывода массива на экран

// PrintArray2(new_array);


// void Replacement(int[,] new_array)
// {
//     for(int i = 0; i < new_array.GetLength(0); i++)
//     {
//         for(int j = 0; j < new_array.GetLength(1); j++)
//         {
//             if(new_array[i, j] % 2 == 0)
//             {
//                 new_array[i, j] += 1;
//             }
//             Console.Write($"{new_array[i , j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // Функция для замены четных элементов двумерного массива

// Replacement(new_array);








// Задать двумерный массив следующим правилом: Aₘₙ = m+n


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









// В двумерном массиве заменить элементы, 
// у которых оба индекса чётные на их квадраты


// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreatArray(int m, int n)
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


// int[,] arr = CreatArray(m, n);
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

// // Функция для вывода массива на экран


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








// В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, что такого элемента нет

// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreatArray(int m, int n)
// {
//     int[,] array = new int [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// // Функция для создания двумерного массива


// int[,] arr = CreatArray(m, n);
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

// // Функция для вывода массива на экран

// void UserNumber(int[,] arr)
// {
//     Console.Write("Please enter the number you want to find in the array: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(arr[i, j] == number)
//             {
//                 Console.Write($"{i}, {j}");
//             }
//             else
//             {
//                 Console.Write("Error");
//             }
//         }

//     }
// }
// UserNumber(arr);









// Задайте двумерный массив. 
// Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreatArray(int m, int n)
// {
//     int[,] array = new int [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// // Функция для создания двумерного массива



// int[,] arr = CreatArray(m, n);
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
// Функция для нахождения суммы главной диоганали


// int res = NewArray(arr);

// Console.Write($"Сумма элементов главной диагонали: {res}");







// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


// int[,] CreateArray(int x, int y)
// {
//     int[,] array = new int [x, y];
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
// // Функция для вывода массива на экран




// void ArithmeticMean(int[,] new_arr)
// {
//     for(int i = 0; i < new_arr.GetLength(0); i++)
//     {
//         int[] res = new int [new_arr.GetLength(1)];
//         for(int j = 0; j < new_arr.GetLength(1); j++)
//         {
//             res[i] += new_arr[j, i];
//         }
//         Console.Write($"{res[i] / new_arr.GetLength(1)}; ");
//     }
// }
// // Функция для вычисления среднего арифметического
// // Скажу честно, я нашел вариант решения в инете, но если я так делаю я разбираюсь
// // как и почему это работает. Но здесь мои полномочия все), в принципе я понял
// // как работает new_arr[j, i], но не понял почему у нас не меняется итерация строк
// // пока у нас не закончится итерация таблицы 
// // (если бы вы мне обьяснили было бы неплохо)



// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] new_arr = CreateArray(x, y);
// // присваиваем переменной arr массив из  функции CreateArray

// PrintArray(new_arr);

// ArithmeticMean(new_arr);









// Написать программу, которая обменивает 
// элементы первой строки и последней строки

// int[,] CreateArray(int x, int y)
// {
//     int[,] array = new int [x, y];
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
// // Функция для вывода массива на экран


// int[,] ReplacingString(int[,] arr)
// {
//     int[,] array = new int [arr.GetLength(0), arr.GetLength(1)];

//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         int temp = arr[0, i];
//         arr[0, i] = arr[arr.GetLength(1) - 1, i];
//         arr[arr.GetLength(1) - 1, i] = temp;
//     }

//     for(int j = 0; j < arr.GetLength(0); j++)
//     {
//         for(int k = 0; k < arr.GetLength(1); k++)
//         {
//             array[j, k] = arr[j, k];
//         }
//     }
//     return array;
// }


// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] arr = CreateArray(x, y);

// PrintArray(arr);

// int[,] res = ReplacingString(arr);
// PrintArray(res);











// Написать программу, 
// упорядочивания по убыванию элементы каждой строки двумерного массива.


// int[,] CreateArray(int x, int y)
// {
//     int[,] array = new int [x, y];
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
// // Функция для вывода массива на экран



// int[,] Sorting(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(1); k++)
//             {
//                 if (arr[i, j] <= arr[i, k])
//                 {
//                     int temp = arr[i, j];
//                     arr[i, j] = arr[i, k];
//                     arr[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return arr;
// }
// // Функция для сортировки двумерного массива по строкам





// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] arr = CreateArray(x, y);

// PrintArray(arr);

// int[,] array = Sorting(arr);

// PrintArray(array);












// 2-й метод(свой)

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
// // Функция для вывода двумерного массива в консоль

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












// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).


// int[,] CreateArray(int x, int y)
// {
//     int[,] array = new int [x, y];
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
// // Функция для вывода массива на экран


// void ArrayReverse(int[,] arr)
// {
//     if(arr.GetLength(0) == arr.GetLength(1))
//     {
//         for(int i = 0; i < arr.GetLength(0); i++) 
//         {
//             for(int j= i + 1; j < arr.GetLength(1); j++) 
//             {
//                 int temp = arr[i, j];
//                 arr[i, j] = arr[j, i];
//                 arr[j, i] = temp;
//             }
//         }
//         PrintArray(arr);
//     }
//     else
//     {
//         Console.WriteLine("Error ");
//     }
// }



// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] arr = CreateArray(x, y);

// PrintArray(arr);

// ArrayReverse(arr);














// Рекурсия 

// Показать натуральные числа от 1 до N, N задано

// Console.Write("Enter a natural number greater than 1: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string NaturalNumbers(int n){
//     if(n < 0){
//         return "-1";
//     }
//     if (n == 1) {
//         return "1";
//     }
//     return NaturalNumbers(n - 1) + " " + n;

// }
// // Функция для вывода натуральных чисел от 1 до n

// string res = NaturalNumbers(n);
// Console.Write(res);







// Показать натуральные числа от N до 1, N задано

// void OutputOfNaturalNumbers(int n)
// {
//     if (n < 0){
//         Console.Write($"{n} not a natural number");
//     } 
//     if (n > 0){
//         Console.Write($"{n}, ");
//         OutputOfNaturalNumbers(n - 1);
//     }
// }
// // Функция для вывода натуральных чисел от n до 1

// OutputOfNaturalNumbers(n);






// Показать натуральные числа от M до N, N и M заданы

// Console.Write("Enter a natural number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a natural number N: ");
// int n = Convert.ToInt32(Console.ReadLine());


// string Range(int m, int n){
//     if(m < 1 || n < 1 || m > n){
//         if(m == n){
//             return $"{m}";
//         }
//         return "-1";
//     }
//     else {
//         return m + " " + Range(m + 1, n);
//     }
    
// }
// string result = Range(m, n);
// Console.WriteLine(result);





// 4 Игра

// В свободное время одноклассники Вася и Петя любят играть в различные 
// логические игры: морской бой, крестики-нолики, шахматы, шашки и многое другое. 
// Ребята уже испробовали и поиграли во всевозможные 
// классические игры подобного рода, включая компьютерные. 
// Однажды им захотелось сыграть во что-нибудь новое, 
// но ничего подходящего найти не удалось. 
// Тогда Петя придумал следующую игру «Угадайка»: 
// Играют двое участников. Первый загадывает любое трехзначное число, 
// такое что первая и последняя цифры отличаются друг от друга более чем на единицу.
// Далее загадавший число игрок переворачивает загаданное число, 
// меняя первую и последнюю цифры местами, таким образом получая еще одно число. 
// Затем из максимального из полученных двух чисел вычитается минимальное. 
// Задача второго игрока – угадать по первой цифре полученного 
// в результате вычитания числа само это число. Например, 
// если Вася загадал число 487, то перестановкой первой и последней цифры 
// он получит число 784. После чего ему придется вычесть из 784 число 487, 
// в результате чего получится число 297, которое и должен отгадать 
// Петя по указанной первой цифре «2», взятой из этого числа. 
// Петя успевает лучше Васи по математике, поэтому практически всегда 
// выигрывает в играх такого типа. Но в данном случае Петя схитрил и 
// специально придумал такую игру, в которой он не проиграет 
// Васе в любом случае. Дело в том, что придуманная Петей игра имеет 
// выигрышную стратегию, которая заключается в следующем: искомое число всегда 
// является трехзначным и вторая его цифра всегда равна девяти,
//  а для получения значения последней достаточно отнять от девяти первую, 
//  т.е. в рассмотренном выше случае последняя цифра равна 9-2=7. 
//  Помогите Пете еще упростить процесс отгадывания числа по заданной 
//  его первой цифре, написав соответствующую программу.

// Входные данные
// В единственной строке входного файла INPUT.TXT задана единственная цифра К, 
// соответствующая первой цифре полученного Васей в результате 
// вычитания наименьшего загаданного Васей значения из наибольшего.

// Выходные данные
// В выходной файл OUTPUT.TXT нужно вывести значение полученной Васей разности.


// Console.Write("enter a number: ");
// int k = Convert.ToInt32(Console.ReadLine());

// 1 вариант решения
// if(k > 0 && k < 10){
//     int b = 9 - k;
//     k = k * 100 + b + 90;
//     Console.WriteLine(k); 
// }
// else{
//     Console.Write("Error");
// }

// 2 вариант решения
// if(k > 0 && k < 10){
//         Console.Write($"{k}{9}{9-k}");
// }
// else{
//     Console.Write("Error");
// }





// 5 Статистика

// Входные данные
// В первой строке входного файла INPUT.TXT записано единственное число 
// N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
// Вторая строка содержит N чисел, представляющих заданный массив. 
// Каждый элемент массива – натуральное число от 1 до 31. 
// Все элементы массива разделены пробелом.

// Выходные данные
// В первую строку выходного файла OUTPUT.TXT нужно вывести числа, 
// которые соответствуют дням месяцев, в которые Вася получил тройки, 
// а во второй строке соответственно расположить числа месяца, 
// в которые Вася получил четверки. В третьей строке нужно вывести «YES», 
// если Вася может рассчитывать на четверку и «NO» в противном случае. 
// В каждой строчке числа следует выводить в том же порядке, 
// в котором они идут во входных данных. При выводе числа отделяются пробелом.


// Примеры
//  5                        19 31
//  4 16 19 31 2             4 16 2
//                             YES

// 8                         29 7 15 17 1
// 29 4 7 12 15 17 24 1      4 12 24
//                           NO



// Console.Write("Specify how many days it was when you received an English grade: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Evaluations(int n){
//     int[] array = new int [n];
//     int b = 0;
//     int k = 0;
//     if(1 <= n && n <= 31){
//         Console.WriteLine("Enter the days on which you received grades in English: ");
//         for(int i = 0; i < n; i++){
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         for(int j = 0; j < n; j++){
//             if(array[j] % 2 > 0){
//                 Console.Write($"{array[j]} ");
//                 b++;
//             }
//         }
//         Console.WriteLine();
//         for(int l = 0; l < n; l++){
//             if(array[l] % 2 == 0){
//                 Console.Write($"{array[l]} ");
//                 k++;
//             }
//         }
//         Console.WriteLine();

//         if(b >= k){
//             Console.Write("NO");
//         }
//         if(k > b){
//             Console.Write("YES");
//         }
//     }
//     else{
//         Console.WriteLine("Error");
//     }
// }
// Evaluations(n);





// 6 Шахматы

// Совсем недавно Вася занялся программированием 
// и решил реализовать собственную программу для игры в шахматы. 
// Но у него возникла проблема определения правильности хода конем, 
// который делает пользователь. Т.е. 
// если пользователь вводит значение «C7-D5», 
// то программа должна определить это как правильный ход, 
// если же введено «E2-E4», то ход неверный. 
// Также нужно проверить корректность записи ввода: если например, 
// введено «D9-N5», то программа должна определить данную запись как ошибочную. 
// Помогите ему осуществить эту проверку!

// Входные данные
// В единственной строке входного файла INPUT.TXT 
// записан текст хода (непустая строка), 
// который указал пользователь. 
// Пользователь не может ввести строку, длиннее 5 символов.

// Выходные данные
// В выходной файл OUTPUT.TXT нужно вывести «YES», 
// если указанный ход конем верный, если же запись корректна 
// (в смысле правильности записи координат), но ход невозможен, то нужно 
// вывести «NO». Если же координаты не определены или заданы некорректно, 
// то вывести сообщение «ERROR».


// Console.Write("Enter your knight move: ");
// string move = Console.ReadLine();

// void Check(string move){
//     if(move.Length != 5){
//         Console.WriteLine("Error");
//     }
//     else if(move[0] == move[3]){
//         Console.Write("NO");
//     }
//     else if(move.Length == 5){
//         if(Convert.ToInt32(move[1]) == Convert.ToInt32(move[4]) - 1
//         || Convert.ToInt32(move[1]) == Convert.ToInt32(move[4]) - 2
//         || Convert.ToInt32(move[1]) == Convert.ToInt32(move[4]) + 1
//         || Convert.ToInt32(move[1]) == Convert.ToInt32(move[4]) + 2
//         && move[0] != move[3]){
//             Console.WriteLine("YES");
//         }
//     }
// }
// Check(move);







// 9
// Петя успевает по математике лучше всех в классе, 
// поэтому учитель задал ему сложное домашнее задание, 
// в котором нужно в заданном наборе целых чисел найти сумму всех 
// положительных элементов, затем найти где в заданной последовательности 
// находятся максимальный и минимальный элемент и вычислить произведение чисел, 
// расположенных в этой последовательности между ними. Так же известно, 
// что минимальный и максимальный элемент встречаются в заданном множестве чисел 
// только один раз и не являются соседними. Поскольку задач такого 
// рода учитель дал Пете около ста, то Петя как сильный программист смог 
// написать программу, которая по заданному набору чисел самостоятельно находит 
// решение. А Вам слабо?


// Console.Write("Enter the number of numbers: ");
// int numbers = Convert.ToInt32(Console.ReadLine());

// void Composition(int numbers){
//     int[] array = new int [numbers];
//     int compasition = 1, sum = 0, min = array[0], max = array[0];
//     Console.WriteLine("enter the numbers: ");
//     for(int i = 0; i < numbers; i++){
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if(array[i] > 0){
//             sum += array[i];
//         }
//         if(min > array[i]) min = i;
//         if(max < array[i]) max = i;
//     }
//     if(min > max){
//         for(int j = max + 1; j < min; j++){
//             compasition *= array[j];
//             }
//         }
//     if(max > min){
//         for(int k = min; k < max - 1; k++){
//             compasition *= array[k];
//             } 
//         }
//     Console.WriteLine(compasition);
//     Console.WriteLine(sum);

// }
// Composition(numbers);









// Попробую сделать елочку)

// int[,] pic = new int[,]
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 3, 0, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 3, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 1, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 2, 0, 0, 0, 3, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 4, 0, 0, 0, 4, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 3, 0, 0, 0, 0, 2, 0, 0, 3, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 0, 2, 3, 0, 0, 0, 2, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 1, 4, 0, 0, 0, 2, 0, 0, 0, 3, 0, 0, 4, 0, 2, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i,j] == 0) Console.Write($" ");
//             else if(image[i, j] == 2){
//                 Console.ForegroundColor = ConsoleColor.DarkYellow;
//                 Console.Write($"*");
//                 Console.ForegroundColor = ConsoleColor.White;
//             }
//             else if(image[i, j] == 3){
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.Write($"x");
//                 Console.ForegroundColor = ConsoleColor.White;
//             }
//             else if(image[i, j] == 4){
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.Write($"o");
//                 Console.ForegroundColor = ConsoleColor.White;
//             }
//             else {
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.Write($"+");
//                 Console.ForegroundColor = ConsoleColor.White;
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0) 
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(7, 11);
// PrintImage(pic);







// 10

// Вася в школе изучил квадратные уравнения и понял, 
// как они легко решаются путем вычисления дискриминанта. 
// Но Петя поведал ему о методе решения кубических уравнений вида 
// A*X3 + B*X2 + C*X + D = 0. 
// На факультативе по математике Васе задали решить около ста уравнений 
// как раз такого вида. Но, к сожалению, Вася забыл формулы, 
// о которых рассказывал ему Петя. Но Васе было известно, 
// что все корни уравнений – целые числа и 
// находятся на отрезке [-100, 100]. 
// Поэтому у Васи есть шанс найти их методом перебора, 
// но для этого ему придется затратить уйму времени, т.к. 
// возможно необходимо будет осуществить перебор нескольких тысяч значений. 
// Помогите Васе написать программу, которая поможет ему найти 
// корни кубических уравнений!


// int size = 4;

// int[] CreateArray(int size){
//     int[] array = new int [size];
//     Console.WriteLine("Enter A, B, C, D:");
//     for(int i = 0; i < size; i++){
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int[] arr = CreateArray(size);

// int a = arr[0], b = arr[1], c = arr[2], d = arr[3];

// for(int i = -100; i < 100; i++){
//     if(a * (i * i * i) + b * (i * i) + c * i + d == 0){
//         Console.Write($" {i}");
//     }
// }







// ЗАДАЧА №11
// Зайчик

// В нашем зоопарке появился заяц. 
// Его поместили в клетку, и чтобы ему не было скучно, 
// директор зоопарка распорядился поставить в его клетке лесенку. 
// Теперь наш зайчик может прыгать по лесенке вверх, 
// перепрыгивая через ступеньки. Лестница имеет определенное количество ступенек N.
//  Заяц может одним прыжком преодолеть не более К ступенек. 
//  Для разнообразия зайчик пытается каждый раз найти новый 
//  путь к вершине лестницы. Директору любопытно, 
//  сколько различных способов есть у зайца добраться до вершины лестницы 
//  при заданных значениях K и N. Помогите директору написать программу, 
//  которая поможет вычислить это количество. Например, если K=3 и N=4, 
//  то существуют следующие маршруты: 1+1+1+1, 1+1+2, 1+2+1, 2+1+1, 2+2, 1+3, 3+1.
//   Т.е. при данных значениях у зайца всего 7 различных маршрутов 
//   добраться до вершины лестницы.




// Console.WriteLine("enter the number of steps: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter the number of steps that the bunny can jump over: ");
// int k = Convert.ToInt32(Console.ReadLine());

// int Bunny(int n, int k){
//     int count = 0;
//     int numb = 1;
//     if(n > k){
//         for(int i = 0; i < n; i++){
//             numb += numb;
//             if(numb == n){
//                 count = count + 1;
//             }
//         }
//     }
//     return count;
// }

// int res = Bunny(n, k);
// Console.Write(res);