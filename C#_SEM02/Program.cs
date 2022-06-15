
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
// 
// Console.WriteLine("Input integer: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 2)
// {
//     int count = 2;
//     while (count <= num)
//     {
//         Console.Write(count + " ");
//         count = count + 2;
//     }
// }
// else
//     Console.WriteLine("Incorrect number");

// Seminar 2 14.06.22

// Case 1
// To print out random number at [10,99] and the biggest letter of this number
//
// void ShowNumber(){
//     int num = new Random().Next(10, 100);
//     int firstNum = num / 10;
//     int secondNum = num % 10;
//     Console.Write(num + " -> ");
//     if(firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else{
//         Console.WriteLine(secondNum);
//     }
// }
//
// ShowNumber();
//
// Case 2
// To print out random number (100 - 999) whitout middle symbol: 456 -> 46
//
// int NumberWithoutSecDig(int num){
//     int newnum = 0;
//     newnum = num / 100 * 10 + num % 10;
//     return newnum;
// }
// int num = new Random().Next(100, 1000);
// int a = NumberWithoutSecDig(num);
// Console.WriteLine(num + " -> " + a);
//
// Case 3
// to determinate if the number B is a multiple of the number A
//
// void MultiNum(int a, int b)
// {
//     if(b%a == 0){
//         Console.WriteLine(b + " is a multiple of " + a);
//     }
//     else{
//         Console.WriteLine(b + " is NOT a multiple of " + a +", remainder is " + b%a);
//     }
// }
// Console.WriteLine("Input two numbers: ");
// int num1= Convert.ToInt32(Console.ReadLine());
// int num2= Convert.ToInt32(Console.ReadLine());
// MultiNum(num1, num2);
//
//Case 4
// to determinate if the number is a multiple of 7 and 23 at the same time
//
// void Multiple(int num)
// {
//     if(num%7 == 0 && num%23 == 0){
//         Console.WriteLine(num + " is a multiple of 7 and 23 at the same time");
//     }
//     else{
//         Console.WriteLine(num + " is NOT a multiple of 7 and 23 at the same time");
//     }
// }
// Console.WriteLine("Input one number: ");
// // int num= Convert.ToInt32(Console.ReadLine());
// // Multiple(num);
// Multiple(Convert.ToInt32(Console.ReadLine()));
//
//Case 5
// to determine that the number Y is the square of the number X
//
// void Squaring(int x, int y)
// {
//     if(x * x == y){
//         Console.WriteLine(y + " is the square of the number " + x);
//     }
//     else{
//         Console.WriteLine(y + " is NOT the square of the number " + x);
//     }
// }
// Console.WriteLine("Input number and square of this number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// Squaring(x, y);
//
// Home work at 15.06.22
//
//Case 1 ------------------------------------------------------------
// to type the middle digit of the three digit number
//
// int Get2ndDig(int num){
//     int newnum = 0;
//     newnum = num / 10 - num / 100 * 10 ;
//     return newnum;
// }
//
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 100 || num > 999)
//     Console.WriteLine("Incorrect number. Please try again.");
// else{
//
//     Console.WriteLine("Middle digit is " + Get2ndDig(num));
//     Console.WriteLine(num + " -> " + Get2ndDig(num));
// }
//
//Case 2 ------------------------------------------------------------
// to type 3rd digit of the entered number
//
// int GetNumDig(int Num){  // to determine the number of digits
//     int NumDig = 0;
//     while (Num >= 1){
//         NumDig++;
//         Num = Num / 10;
//     }
//     return NumDig;
// }
// //
// int Get3Dig(int Num, int DigNum){  // to remove digits after 3rd character
//     if(DigNum > 3){
//         int nLoop = DigNum - 3;
//         int iLoop = 1;
//         while(iLoop <= DigNum - 3){
//             Num = Num / 10;
//             iLoop++;
//         }
//     }
//     return Num;
// }
// // to enter the number num
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num <= 0)
//     Console.WriteLine("Incorrect number. Please try again.");
// else if(num < 100)
//     Console.WriteLine("third digit is missing. Please try again.");
// else{
//     int DigNum = GetNumDig(num);  // to get the number of digits
//     if(DigNum > 3) num = Get3Dig(num, DigNum);  // to remove digits after 3rd character
//     Console.WriteLine("3rd digit is " + num % 10);  // to type 3rd digit
// }
//    
//Case 3 ------------------------------------------------------------
// to check if the current day is a holiday
//
void TypeDay(int Day){
string [] WeekDay = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
if(Day>0 && Day < 8){
    Console.WriteLine("Curreny day is " + WeekDay[Day-1]);
    if(Day > 5) Console.WriteLine(Day + " -> it's the weekend");
    else Console.WriteLine(Day + " -> it's not the weekend");
} 
else
    Console.WriteLine("Incorrect current day number. Please try again.");
}

Console.WriteLine("Input number indicating the day of the week");
int CurDay = Convert.ToInt32(Console.ReadLine());
TypeDay(CurDay);
//