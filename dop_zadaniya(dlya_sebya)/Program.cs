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


