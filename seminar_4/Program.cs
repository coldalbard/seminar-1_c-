// Console.Write("Please, enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SummNumbers(int number)
// {
//     int sum = 0;
//     for(int i = 1; i <= number; i ++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// int res = SummNumbers(number);
// Console.WriteLine($"sum = {res}");



// Console.Write("Please, enter your number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int Summ(int number1)
// {
//     int summ = 0;
//     int i = 1;
//     while(i <= number1)
//     {
//         summ += i;
//         i++;
//     }
//     return summ;
// }
// int res1 = Summ(number1);
// Console.WriteLine($"sum = {res1}");



// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

// Console.Write("Please, enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int Num(int num)
// {
//     if (num == 0)
//     {
//         return 1;
        
//     }
//     else {int sum = 0;

//     while(num > 0)
//     {
//         sum ++;
//         num = num / 10;
//     }
//     return sum;
//     }
// }
// int res = Num(num);
// Console.WriteLine(res);





// Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.


// Console.Write("Please, enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int Fact(int num)
// {
//     if(num < 0)
//     {
//         num = num * (-1);
//     }
//     int sum = 1;
//     for(int i = 2; i <= num; i++)
//     {
//         sum = sum * i;

//     }
//     return sum;
// }
// int res = Fact(num);
// Console.WriteLine(res);





// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.


// Console.Write("Please, enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] Array(int number)
// {
//     int [] arr = new int [number];
//     for (int i = 0; i < number; i++)
//     {
//         arr[i] = new Random().Next(5,16);
//     }

//     return arr;
// }
// void ShowArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// ShowArray(Array(number));
