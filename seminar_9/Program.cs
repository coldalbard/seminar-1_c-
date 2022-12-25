
// void ShowNumbers(int n){
//     if(n > 1) ShowNumbers(n - 1);
//     Console.Write(n + " ");
// }

// Console.Write("Enter a natural number greater than 1: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);


// void ShowNumbersMN(int n, int m){
//     Console.Write($"{Math.Min(n, m)} ");
//     if(Math.Max(n, m) != Math.Min(n, m)) 
//         ShowNumbersMN(Math.Max(n, m), Math.Min(n, m) + 1);
// }


// Console.Write("Enter a natural number greater than 1: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a natural number greater than 1: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbersMN(m, n);






// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Enter a natural number greater than 1: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int m){
//     if(m < 0){
//         m *= -1;
//     }
//     if(m > 0){      
//         return SumNumbers(m / 10) + m % 10; 
//     }
//     else{
//         return 0;
//     }
// }

// int res = SumNumbers(m);
// Console.Write(res);

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Enter a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter b: ");
// int b = Convert.ToInt32(Console.ReadLine());


// double Stepen(int a, int b){

//     if(b > 0) return Stepen(a, b - 1) * a;
//     if(b < 0) return Stepen(a, b + 1) / a;
//     return 1.0;
// }
// double result = Stepen(a, b);
// Console.Write(result);

