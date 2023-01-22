// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
//
// Sum of elements in loo2
int SumLoop(int i1, int i2)
{
    int sum = 0;
    int iStart = i1; int iFinish = i2;
    if (i2 < i1)
    {
        iStart = i2; iFinish = i1;
    }
    for (int i = iStart; i <= iFinish; i++) sum += i;
    return sum;
}
// Input of m and n
Console.Clear();
Console.Write("Enter positive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m > 0 && n > 0)
{
// Output of Akkerman function value
// Output of sum
    Console.WriteLine();
    Console.WriteLine($"{SumLoop(m,n)} is sum of natural elements between {m} and {n}");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"Input error");
    Console.WriteLine($"Invalid value of m={m} or n={n}");
}




// //Задача 68: Напишите программу вычисления функции Аккермана Ak(m,n) с помощью рекурсии.
// // Даны два неотрицательных числа m и n.
// //
// // Функция Аккермана Ak(m,n) определяется как
// // for m=0 -> Ak(m,n)=n+1;
// // for m>0 and n=0 -> Ak(m,n)=Ak(m-1,1);
// // for m>0 and n>0 -> Ak(m,n)=Ak(m-1,Ak(m,n-1)).
// // Akkerman function Ak(m,n)
// int IntAkkerman(int m,int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0) return IntAkkerman(m - 1, 1);
//     return IntAkkerman(m - 1, IntAkkerman(m, n - 1));
// }
// // Input of m and n
// Console.Clear();
// Console.Write("Enter non-negative number m in Akkerman function Ak(m,n) ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter non-negative number n in Akkerman function Ak(m,n) ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(m >= 0 && n >= 0)
// {
// // Output of Akkerman function value
//     Console.WriteLine();
//     Console.WriteLine($"{IntAkkerman(m,n)} is Akkerman function for m={m} and n={n}");
//     Console.WriteLine();
// }
// else
// {
//     Console.WriteLine($"Input error");
//     Console.WriteLine($"Invalid value of m={m} or n={n}");
// }
//
