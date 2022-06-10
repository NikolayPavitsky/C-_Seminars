// Seminar 10.06.22

// Console.WriteLine("Input integer: ");
// int num= Convert.ToInt32(Console.ReadLine());
// // int num= Convert.ToInt32(Console.Read());
// Console.WriteLine("num= " + num);
// int result = num * num;
// Console.WriteLine("result= " + result);

// Console.WriteLine("Input 2 integers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//     Console.WriteLine(" num1=num2*num2");
// }
// Console.WriteLine("Input number of a day");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day <1 || day > 7) {
//     Console.WriteLine("Incorrect day number");
// }

// else {
//     if(day == 1){
//         Console.WriteLine("monday");
//     }
//     if(day == 2){
//         Console.WriteLine("tuesday");
//     }
//     if(day == 3){
//         Console.WriteLine("wednesday");
//     }
//     if(day == 4){
//         Console.WriteLine("thursday");
//     }
//     if(day == 5){
//         Console.WriteLine("friday");
//     }
//     if(day == 6){
//         Console.WriteLine("saturday");
//     }
//     if(day == 7){
//         Console.WriteLine("sunday");
//     }
// }

// Console.WriteLine("Input integer: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = - num + 1;
// while (count < num)
// {
//     Console.Write(count + " ");
//     count = count + 1;
// }

// Console.WriteLine("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // 123 / 10=12.3 , 123 // 10 = 12,  123 % 10 = 3 
// Console.WriteLine(num % 10);

//  Home work 10.06.22

// // Task 2
// Console.WriteLine("Input two integers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 > num2){
//     Console.WriteLine("first number greater than second");
// }
// else{
//     if(num1 < num2){
//         Console.WriteLine("first number less than second");
//     }
//     else{
//         Console.WriteLine("first number equals second");
//     }
// }
// // Task 4
// Console.WriteLine("Input three integers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int nmax = num1;
// if(num2 > nmax) nmax = num2;
// if(num3 > nmax) nmax = num3;
// Console.WriteLine("maximum number is " + nmax);
// // Task 6
// Console.WriteLine("Input integer: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
//     Console.WriteLine("This is an even number");
// else
//     Console.WriteLine("This is an odd number");
// Task 8
Console.WriteLine("Input integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 2)
{
    int count = 2;
    while (count <= num)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
else
    Console.WriteLine("Incorrect number");
