// Seminar 3; 18.06.22

// Case 1
// To print out the quarter number of the point
// void GetPoint(int x, int y){
//     if(x == 0){
//         Console.WriteLine("zero value of x, it is impossible to determine the number of a quarter");
//     }
//     else if(y == 0){
//         Console.WriteLine("zero value of y, it is impossible to determine the number of a quarter");
//     }
//     else{
//         if(x > 0 && y > 0){
//             Console.WriteLine("1st quarter");
//         }
//         else if(x > 0 && y < 0){
//             Console.WriteLine("2nd quarter");
//         }
//         else if(x < 0 && y > 0){
//             Console.WriteLine("3rd quarter");
//         }
//         else if(x < 0 && y < 0){
//             Console.WriteLine("4th quarter");
//         }
//     }
// }
// Console.WriteLine("Input x and y coordinates: ");
// int x= Convert.ToInt32(Console.ReadLine());
// int y= Convert.ToInt32(Console.ReadLine());
// GetPoint(x, y);

// Case 2
// To print out x & y for the quarter number
// void GetPoints(int num){
//     if(num == 1) Console.WriteLine("x > 0, y > 0");
//     else if(num == 2) Console.WriteLine("x > 0, y < 0");
//     else if(num == 3) Console.WriteLine("x < 0, y > 0");
//     else if(num == 4) Console.WriteLine("x < 0, y < 0");
//     else Console.WriteLine("wrong value of the quarter number");
// }
// Console.WriteLine("Input the quarter number (1 - 4): ");
// int num= Convert.ToInt32(Console.ReadLine());
// GetPoints(num);

// Case 3
// To get distance between two points
// httpS://docs.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-6.0
//
// First edition
//
// Console.Clear();
// double dist(int[] x, int[] y){
//     return Math.Sqrt(Math.Pow(x[1]-x[0], 2) + Math.Pow(y[1]-y[0],2));
// }
// int[] x = new int[2];
// int[] y = new int[2];
// Console.WriteLine("Input x and y coordinates: ");
// Console.WriteLine("for 1st point");
// x[0] = Convert.ToInt32(Console.ReadLine());
// y[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("for 2nd point");
// x[1] = Convert.ToInt32(Console.ReadLine());
// y[1] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Distance is " + dist(x, y));
//
// Second edition
//
// Console.Clear();
// double distAB(int xA, int yA, int xB, int yB){
//     return Math.Sqrt(Math.Pow(Math.Abs(xB-xA), 2) + Math.Pow(Math.Abs(yB-yA),2));
// }
// Console.WriteLine("Input x and y coordinates: ");
// Console.WriteLine("for 1st point");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("for 2nd point");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Distance is " + Math.Round(distAB(xB:x2, yB:y2, xA:x1, yA:y1),2));

// Case 4
// To get the squares of the numbers from 1 to Num

// void ListSqrt(int num){
//     int count = 1;
//     while(count <= num){
//         Console.WriteLine("Squere of " + count + " is " + Math.Pow(count, 2));
//         count++;
//     }
// }
// Console.WriteLine("Please enter a positive non-zero number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 0)
//     ListSqrt(num);
// else
//     Console.WriteLine("Incorrect number. Please try again.");

//
// Home work at 20.06.22
//
//Task 19 ------------------------------------------------------------
// to identify palindrome
//
// int Palindrome(int Num){
//     int NumPlnd = 0;
//     int num1 = 1;
//     int num2 = 10000;
//     for(int i = 1; i <= 5; i++){        
//         NumPlnd = NumPlnd + ((Num / num2) % 10) * num1;
// // Console.WriteLine("i=" + i + " NumPlnd=" + NumPlnd + "num1=" + num1 + "num2=" + num2);
//         num1 = num1 * 10;
//         num2 = num2 / 10;
//     }
//     return NumPlnd;
// }
// Console.Clear();
// Console.WriteLine("Please enter a five-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 9999 && num <= 99999)
//     if(num == Palindrome(num))
//         Console.WriteLine("It's the polindrome");
//     else
//         Console.WriteLine("It is NOT the polindrome");
// else
//     Console.WriteLine("Incorrect number. Please try again.");

//
//Task 21 ------------------------------------------------------------
// to calculate distance between two points set in 3d
//

// Console.Clear();
// double distAB3d(int xA, int yA, int zA, int xB, int yB, int zB){
//     return Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
// }
// Console.WriteLine("Input x, y and z coordinates: ");
// Console.WriteLine("for 1st point");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("for 2nd point");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Distance is " + Math.Round(distAB3d(xB:x2, yB:y2, zB:z2, xA:x1, yA:y1, zA:z1),4));

//
//Task 23 ------------------------------------------------------------
// To get degree 3 of the numbers from 1 to Num
//

void ListCube(int num){
    int count = 1;
    Console.Write(num + " -> ");
    while(count <= num){
        Console.Write(Math.Pow(count, 3));
        if(count < num) Console.Write(", ");
        count++;
    }
}
Console.WriteLine("Please enter a positive non-zero number");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    ListCube(num);
else
    Console.WriteLine("Incorrect number. Please try again.");
