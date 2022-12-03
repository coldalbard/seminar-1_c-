// void Test(int a, int b){
//     if(a > b)
//     {
//         Console.WriteLine($"{a} больше {b}");
//     }
//     else
//     {
//         Console.WriteLine($"{b} больше {a}");
//     }
// }
// Test(1, 2);



// int num1 = 4;
// int num2 = 5;

// Console.WriteLine(Test(num1, num2));

// int Test(int a, int b){
//     if(a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// int num1 = 5;
// int num2 = 4;

// int result = Test(num1, num2);
// Console.WriteLine($"Результат - {result}");



// int Line(){
//     int num = new Random().Next(10, 100);
//     Console.WriteLine($"ваше число - {num}");
//     int dec = num / 10;
//     int ed = num % 10;
//     if(dec > ed)
//     {
//         return dec;
//     }
//     else if (dec == ed)
//     {
//         return ed;
//     }
//     else
//     {
//         return ed;
//     }
// }
// int res = Line();
// Console.WriteLine($"большое число - {res}");








// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int Line(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine($"ваше число - {num}");
//     int sot = num / 100;
//     int des = num / 10 % 10;
//     int ed = num % 10;
//     return((sot * 10) + ed);
// }
// int res = Line();
// Console.WriteLine("numb, "+ (res));

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

// Console.WriteLine("Enter your number: ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter your number: ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// int Numb(int numb1, int numb2)
// {
//     numb1 = new Random().Next(1, 10);
//     numb2 = new Random().Next(1, 10);
//     if(numb1 % numb2 == 0)
//     {
//         return (numb1);
//     }
//     else if(numb1 % numb2 != 0)
//     {
//         int res2 = (numb1 % numb2);
//         return res2;
//     }
// }
// int res1 = Numb(numb1, numb2);
// Console.WriteLine(res1);






//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

// Console.WriteLine("Enter your number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter your number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void Kvad(int num1, int num2){
//     if(num1 * num1 == num2){
//         Console.WriteLine("yes");
//     }
//     else if(num2 * num2 == num1)
//     {
//         Console.WriteLine("Yes");
//     }
//     else 
//     {
//         Console.WriteLine("No");
//     }
// }    
// Kvad(num1, num2);





// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
// Console.WriteLine("Enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// void Krat(int number)
// {
//     if((number % 7 == 0)&&(number % 23 == 0)){
//         Console.Write("yes");
//     }
//     else
//     {
//         Console.Write("No");
//     }
// }
// Krat(number);