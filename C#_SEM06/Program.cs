// Seminar

// Case 1
// to Swap array
//
// int[] SetRandomArr(int size, int min, int max){ // to fill array
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// //
// int[] SwapArray(int[] arr){ // to swap array
//     for(int i = 0, j = arr.Length - 1; i < arr.Length/2+arr.Length%2; i++, j--){
//         int save = arr[i];
//         arr[i] = arr[j];
//         arr[j] = save;
//     }
//     return arr;
// }
// //
// void ShowArr(int[] arr){ // to show array
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// //
// Console.WriteLine("Please enter size of array");
// int SizArr = Convert.ToInt32(Console.ReadLine());
// if(SizArr > 0){
//     int[] Arr = SetRandomArr(SizArr, -99, 99);
//     ShowArr(Arr);
//     Console.Write(" -> ");
//     ShowArr(SwapArray(Arr));
// }
//
// Case 2
// To test 3 values are 3 sides of triangle
// Each side of the triangle less then sum of other two sides
//
// double[] SetRandomArr(int size, double min, double max){ // set 3 values and save in array
//     double [] arr = new double[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().NextDouble() * (max - min);
//     }
//     return arr;
// }
// //
// void ShowArr(double[] arr){  // to show array
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write("{0:f2} ", arr[i]);
//     }
// }
// //
// bool TestTriangle(double[] arr){  // test each side less sum of two other sides
//     if(arr[0] < arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[0] + arr[1]) return true;
//     else return false;
// }
// //
// double[] Arr = SetRandomArr(3, 1, 9);
// ShowArr(Arr);
// Console.Write("-> ");
// if(TestTriangle(Arr)) Console.Write("Yes");  // it is triangle
// else Console.Write("No");                    // it is NOT triangle
//

//
// Home work 
//

// Task 41
// To count number of positive values
//
// int CountPosNum(int [] arr){ // to count positive values
//     int PosNum = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] > 0) PosNum++;
//     }
//     return PosNum;
// }
// void ShowArr(int[] arr){ // to show array
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// //
// Console.WriteLine("Please enter positive number");
// int SizArr = Convert.ToInt32(Console.ReadLine());
// if(SizArr > 0) {
//     int [] Array = new int[SizArr];
//     Console.WriteLine("Please enter " + SizArr + "numbers");
//     for(int i = 0; i < SizArr; i++){
//         Array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     ShowArr(Array);
//     Console.WriteLine(" -> " + CountPosNum(Array));
// }
// else Console.WriteLine("Incorrect numder. Please try again");
//
// Task 42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
//
// int ConvertDecBin(int num){
//     int BinNum = 0;
//     int count = 0;
//     while(num >= 1){
//         if(count == 0) count = 1;
//         else count = count * 10;
//         BinNum = BinNum + (num % 2) * count;
//         num = num / 2;
//     }
//     return BinNum;
// }
// Console.WriteLine("Please enter positive number");
// int DecNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecNum + " -> " + ConvertDecBin(DecNum));
// //
// // Second way by means string
// //
// string number = DecNum.ToString();
// int fromBase = 10;
// int toBase = 2;
// string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
// Console.WriteLine("Second way: " + result);
//
//
// Task 43
// To get intersection point of two lines set by 
// y = k1 * x + b1 and y = k2 * x + b2
//
// double[] CoorIntersect(double K1, double B1, double K2, double B2, double[] arr) // to calculate coordinates of intersection
// {
//     arr[0] = ( B2 - B1 ) / ( K1 - K2 );
//     arr[1] = K1 * arr[0] + B1;
//     return arr;
// }
// //
// Console.WriteLine("y = k1 * x + b1, please enter k1 and b1");
// double K1 = Convert.ToDouble(Console.ReadLine());
// double B1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("y = k2 * x + b2, please enter k2 and b2");
// double K2 = Convert.ToDouble(Console.ReadLine());
// double B2 = Convert.ToDouble(Console.ReadLine());
// if(K1 == K2){
//     Console.WriteLine("lines do not intersect because K1=K2, please try again");
// }
// else{
//     double [] xy = new double [2] {0, 0}; // coord. of intersection
//     CoorIntersect(K1, B1, K2, B2, xy);
//     Console.Write($"k1={K1}, b1={B1}, k2={K2}, b2={B2} -> ");
//     Console.Write($"({xy[0]}, {xy[1]})");
// }

//
// Task 44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//
double[] Fibonacci(double[] arr, int num){
    arr[0] = 0;
    if(num > 1) arr[1] = 1;
    if(num > 2) {
        for(int i = 2; i < num; i++){
            arr[i] = arr[i-1] + arr[i-2];
        }
    }
    return arr;
}
void ShowArr(double[] arr){  // to show array
    for(int i = 0; i < arr.Length; i++){
        Console.Write("{0:f2} ", arr[i]);
    }
}
Console.WriteLine("Please enter positive non-zero number");
int Num = Convert.ToInt32(Console.ReadLine());
if(Num > 0) {
    double [] Array = new double[Num];
    Fibonacci(Array, Num);
    Console.Write("N = " +  Num + " -> ");
    ShowArr(Array);
}
else Console.WriteLine("Incorrect numder. Please try again");
