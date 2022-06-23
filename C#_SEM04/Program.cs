// Seminar 4, 21.06.22
//
// Case for sotring of numbers
// int x = 1234;
// Console.WriteLine("Before sorting x=" + x);
// int a1 = x % 10;
// int a2 = x / 10 % 10;
// int a3 = x / 100 % 10;
// int a4 = x / 1000;
// x = a1 * 1000 + a2 * 100 + a3 * 10 + a4;
// Console.WriteLine("After sorting x=" + x);

//
// To get sum of numbers from 1 to A
// int CalcSum(int num){
//     int sum = 0;
//     for(int i = 1; i <= num; i++ ){
//         sum = sum + i;
//     }
//     return sum;
// }
// Console.WriteLine("Please enter a positive non-zero number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 0)
//     Console.WriteLine("Sum is " + CalcSum(num));
// else
//     Console.WriteLine("Incorrect number. Please try again.");

// Task 27
// To get the number of digits in the given number
//
// int CalcNumDigit(int num){
//     int count = 0;
//     int div = num;
//     while( div >= 1){
//         count++;
//         div = div / 10;
//     }
//     return count;
// }
// Console.WriteLine("Please enter a positive non-zero number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 0)
//     Console.WriteLine(num + " -> " + CalcNumDigit(num));
// else
//     Console.WriteLine("Incorrect number. Please try again.");

//
// To get multiplication of numbers from 1 to A
//
// int CalcMult(int num){
//     int mult = 1;
//     for(int i = 2; i <= num; i++ ){
//         mult = mult * i;
//     }
//     return mult;
// }
// Console.WriteLine("Please enter a positive non-zero number");

// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 0)
//     Console.WriteLine("multiplication of numbers is " + CalcMult(num));
// else
//     Console.WriteLine("Incorrect number. Please try again.");


// Format a negative integer or floating-point number in various ways.
/*
        Console.WriteLine("Standard Numeric Format Specifiers");
        Console.WriteLine(
            "(C) Currency: . . . . . . . . {0:C}\n" +
            "(D) Decimal:. . . . . . . . . {0:D}\n" +
            "(E) Scientific: . . . . . . . {1:E}\n" +
            "(F) Fixed point:. . . . . . . {1:F}\n" +
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(N) Number: . . . . . . . . . {0:N}\n" +
            "(P) Percent:. . . . . . . . . {1:P}\n" +
            "(R) Round-trip: . . . . . . . {1:R}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            -123, -123.45f);

        // Format the current date in various ways.
        Console.WriteLine("Standard DateTime Format Specifiers");
        Console.WriteLine(
            "(d) Short date: . . . . . . . {0:d}\n" +
            "(D) Long date:. . . . . . . . {0:D}\n" +
            "(t) Short time: . . . . . . . {0:t}\n" +
            "(T) Long time:. . . . . . . . {0:T}\n" +
            "(f) Full date/short time: . . {0:f}\n" +
            "(F) Full date/long time:. . . {0:F}\n" +
            "(g) General date/short time:. {0:g}\n" +
            "(G) General date/long time: . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(M) Month:. . . . . . . . . . {0:M}\n" +
            "(R) RFC1123:. . . . . . . . . {0:R}\n" +
            "(s) Sortable: . . . . . . . . {0:s}\n" +
            "(u) Universal sortable: . . . {0:u} (invariant)\n" +
            "(U) Universal full date/time: {0:U}\n" +
            "(Y) Year: . . . . . . . . . . {0:Y}\n",
            thisDate);

        // Format a Color enumeration value in various ways.
        Console.WriteLine("Standard Enumeration Format Specifiers");
        Console.WriteLine(
            "(G) General:. . . . . . . . . {0:G}\n" +
            "    (default):. . . . . . . . {0} (default = 'G')\n" +
            "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
            "(D) Decimal number: . . . . . {0:D}\n" +
            "(X) Hexadecimal:. . . . . . . {0:X}\n",
            Color.Green);
    }
}

This code example produces the following results:

Standard Numeric Format Specifiers
(C) Currency: . . . . . . . . ($123.00)
(D) Decimal:. . . . . . . . . -123
(E) Scientific: . . . . . . . -1.234500E+002
(F) Fixed point:. . . . . . . -123.45
(G) General:. . . . . . . . . -123
    (default):. . . . . . . . -123 (default = 'G')
(N) Number: . . . . . . . . . -123.00
(P) Percent:. . . . . . . . . -12,345.00 %
(R) Round-trip: . . . . . . . -123.45
(X) Hexadecimal:. . . . . . . FFFFFF85

Standard DateTime Format Specifiers
(d) Short date: . . . . . . . 6/26/2004
(D) Long date:. . . . . . . . Saturday, June 26, 2004
(t) Short time: . . . . . . . 8:11 PM
(T) Long time:. . . . . . . . 8:11:04 PM
(f) Full date/short time: . . Saturday, June 26, 2004 8:11 PM
(F) Full date/long time:. . . Saturday, June 26, 2004 8:11:04 PM
(g) General date/short time:. 6/26/2004 8:11 PM
(G) General date/long time: . 6/26/2004 8:11:04 PM
    (default):. . . . . . . . 6/26/2004 8:11:04 PM (default = 'G')
(M) Month:. . . . . . . . . . June 26
(R) RFC1123:. . . . . . . . . Sat, 26 Jun 2004 20:11:04 GMT
(s) Sortable: . . . . . . . . 2004-06-26T20:11:04
(u) Universal sortable: . . . 2004-06-26 20:11:04Z (invariant)
(U) Universal full date/time: Sunday, June 27, 2004 3:11:04 AM
(Y) Year: . . . . . . . . . . June, 2004

Standard Enumeration Format Specifiers
(G) General:. . . . . . . . . Green
    (default):. . . . . . . . Green (default = 'G')
(F) Flags:. . . . . . . . . . Green (flags or integer)
(D) Decimal number: . . . . . 3
(X) Hexadecimal:. . . . . . . 00000003

*/

// To type array filled random values
//
// First variant
//
// DateTime thisDate = DateTime.Now;
// Console.WriteLine("{0:F} \n",thisDate);
// var rand = new Random(); // Instantiate random number generator using system-supplied value as seed
// int [] arr = new int[8];
// for (int i = 0; i < 8; i++)
//     arr[i] = rand.Next(2);
// Console.WriteLine("[{0}]", string.Join(", ", arr));
//
// Second variant
//
// int [] CreateRandomArray(int size, int min, int max){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// int[] CreateArray(int size){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         Console.Write("Input " + i + " element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }
// int[] myRandomarray = CreateRandomArray(8, 0, 1);
// ShowArray(myRandomarray);
// // Console.WriteLine();
// // int[] myArray = CreateArray(8);
// // ShowArray(myArray);

//
// Home work at 23.06.22
//
//Task 25 ------------------------------------------------------------
// to type the number A to the power B
//
// int MyPow(int A, int B){
//     int pow = A;
//     for(int i = 1; i < B; i++){
//         pow = pow * A;
//     }
//     return pow;
// }
// Console.WriteLine("Please enter two positive non-zero numbers");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// if(A > 0 && B > 0)
//     Console.WriteLine(A + ", " + B + " -> " + MyPow(A, B));
// else{
//     Console.WriteLine("Incorrect numbers: A=" + A + " B=" + B);
//     Console.WriteLine("Please try again.");
// }

//
//Task 27 ------------------------------------------------------------
// to type the sum of digits in given number
//
// int CalcSumDigit(int num){
//     int sum = 0;
//     int div = num;
//     while( div >= 1){
//         sum = sum + div % 10;
//         div = div / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Please enter a positive non-zero number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 0)
//     Console.WriteLine(num + " -> " + CalcSumDigit(num));
// else
//     Console.WriteLine("Incorrect number. Please try again.");

//
//Task 29 ------------------------------------------------------------
// to set the array and type it on the screen
//
int [] SetRandomArr(int size, int min, int max){
    int [] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(min,max+1);
    }
    return arr;
}
void ShowArr(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}
int[] myarr = SetRandomArr(8, 1, 100);
ShowArr(myarr);
