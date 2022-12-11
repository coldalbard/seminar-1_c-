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


