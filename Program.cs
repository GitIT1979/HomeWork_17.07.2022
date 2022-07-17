// // 1. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumNaturalBetweenNM(int M, int N) // Вычисление суммы натуральных элементов в промежутке от M до N ыключительно
// {
//     if (M > N) return 0;
//     return M + SumNaturalBetweenNM(M + 1, N); 
// }

// Console.WriteLine("Input M: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Input N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Sum of natural numbers between M and N is {SumNaturalBetweenNM(m, n)}.");


// 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// int AckermannFunction(int m, int n) // Вычисление функции Аккермана
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return AckermannFunction(m - 1, 1);
//   else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
// }

// Console.WriteLine("Input M: ");
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine("Input N: ");
// int N = int.Parse(Console.ReadLine());
// if (M < 0 || N < 0) Console.WriteLine("N и M must be greater then zero!");
// else 
// {
//    Console.WriteLine($"The result of Ackermann function is {AckermannFunction(M, N)}"); 
//    Console.WriteLine();
// }
// Console.WriteLine();

    


