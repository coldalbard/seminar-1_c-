// Console.Write("Please, enter the length of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter arr min element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter arr max element: ");
// int max = Convert.ToInt32(Console.ReadLine());




// int[] CreateArray(int size, int min, int max)
// {
//     int[] arr = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// int[] arr = CreateArray(size, min, max);


// void PrinArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine();
// }
// PrinArray(arr);




// int[] ReverseArray(int[] arr)
// {
//     int l = arr.Length;
//     for(int i = 0; i < l/2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[l - 1 - i];
//         arr[l - 1 - i] = temp;
//     }
//     return arr;
// }

// int[] array = ReverseArray(arr);


// PrinArray(array);












// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int number = 45;

// int[] Array(int number)
// {
//     int count = 0;
//     int temp = number;
//     while(temp != 0)
//     {
//         temp /= 2;
//         count++;
//     }
//     int[] array = new int [count];
//     for(int i = 0; i < count; i++)
//     {
//         array[count - 1 - i] = number % 2;
//         number /= 2;

//     }
//     return array;
// }
// int[] res = Array(number);
// PrinArray(res);







// string BinarySystem(int number)
// {
//     string result = string.Empty;
//     while(number != 0)
//     {
//         result = number % 2 + result;
//         Console.WriteLine(result);
//         number = number / 2;
//     }
//     return result;
// }
// string array = BinarySystem(number);
// Console.WriteLine(array);









// Напишите программу, 
//которая принимает на вход три числа и проверяет, может ли существовать 
//треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника 
//меньше суммы двух других сторон.



// bool Traingle(int a, int b, int c)
// {
//     bool flag = false;
//     if(a + b > c && b + c > a && a + c > b)
//     {
//         flag = true;
//     }
//     return flag;
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// bool flag = Traingle(a, b, c);
// Console.WriteLine(flag);




// int num1 = 5;
// int num2 = 9;

// int n = 5;
// void Fibonacci(int n, int num1, int num2)
// {
//     int[] arr = new int [n];
//     arr[0] = num1;
//     arr[1] = num2;
//     for(int i = 2; i < n; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     PrinArray(arr);
// }
// Fibonacci(n, num1, num2);