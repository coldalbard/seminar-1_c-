// Задача 64: Написать рекурсивную функцию перевода 
// из десятичной системы исчисления в двоичную.

// string BinarySystem(int number){
//     string result = string.Empty;
//     if(number > 0) return BinarySystem(number / 2) + number % 2 + result;
//     if(number < 0) return BinarySystem(number * -1);
//     else return result;
    
// }
// // Функция для перевода в бинарную систему

// // Единственная проблема если пользователь вводит 0, то мой код выводит на экран
// // пустую строку. Я пытался что-то сделать с этим, но потом меняются числа которые
// // должны быть в других случаях, я понимаю почему это так, но исправить не могу(

// Console.Write("Please, enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string binar = BinarySystem(number);
// Console.WriteLine(binar);




// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbersMN(int m, int n){
//     if(m == n) return m;
//     if(m  < n && m > 0 && n > 0) return n + SumNumbersMN(m, n - 1);
//     if(m > n) return n + SumNumbersMN(m, n + 1);
//     else return 0;
// }
// // Функция для нахождения суммы натуральных элементов в промежутке m - n, и от n - m

// Console.Write("Enter a natural number greater than 1: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a natural number greater than 1: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int res = SumNumbersMN(m, n);
// Console.Write(res);

