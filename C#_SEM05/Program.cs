// Seminar 5 at 24.06.22
DateTime thisDate = DateTime.Now;
Console.WriteLine("{0:F} \n",thisDate);
//
// string name = "Name";
// int age = 99;
// Console.WriteLine("name: {0} Age: {1}", name, age);

// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 =string.Format("{0:f5}", number2);
// Console.WriteLine(result2);

// // string name = "Name"
// int age = 99;
// Console.WriteLine($"Name: {name}  Age: {age}");

// int x = 7;
// int y = 8;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// string name = "Nick";
// int age = 99;

// Console.WriteLine($"Name: {name, -10} Age: {age}"); // пробелы после
// Console.WriteLine($"Name: {name, 15} Age: {age}"); // пробелы до

// Task 31
// int [] SetRandomArr(int size, int min, int max){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// void ShowArr(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// int[] myarr = SetRandomArr(12, -9, 9);
// ShowArr(myarr);
// int sumNeg = 0;
// int sumPos = 0;
// for(int i = 0; i < myarr.Length; i++){
//     if(myarr[i] > 0)
//         sumPos = sumPos + myarr[i];
//     else
//         sumNeg = sumNeg + myarr[i];
// }
// Console.WriteLine();
// //Console.WriteLine("sum of positive numbers is " + sumPos);
// //Console.WriteLine("sum of negative numbers is " + sumNeg);
// Console.WriteLine($"sum of positive numbers: {sumPos}");
// Console.WriteLine($"sum of negative numbers: {sumNeg}");
// Console.WriteLine($"sum of positive numbers: {sumPos}. sum of negative numbers: {sumNeg}");
//
// Task 32
//
// int [] SetRandomArr(int size, int min, int max){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// void ShowArr(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// int[] myarr = SetRandomArr(4, -9, 9);
// int [] arr = new int[4];

// for(int i = 0; i < myarr.Length; i++){
//     arr[i] = -myarr[i];
// }
// ShowArr(myarr);
// Console.Write("-> ");
// ShowArr(arr);
//
//
// Task 33
//
// int [] SetRandomArr(int size, int min, int max){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// void ShowArr(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// int[] myarr = SetRandomArr(5, 1, 9);
// Console.WriteLine("Please enter a positive number");
// int GivNum = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for(int i = 0; i < myarr.Length; i++){
//     if(myarr[i] == GivNum) {
//         count = 1;
//         break;
//     }
// }
// Console.Write(GivNum + "; array ");
// ShowArr(myarr);
// Console.Write("-> ");
// if(count == 0)
//     Console.Write("No");
// else
//     Console.Write("Yes");

//
// Home work at 27.06.22
//

//Task 34 ------------------------------------------------------------
// to print the number of even array elements in the range [10-99]
//
// int[] SetRandomArr(int size, int min, int max){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// int CountEvenElements(int[] arr){
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] % 2 == 0)
//             count += 1;
//     }
//     return count;
// }
// void ShowArr(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// Console.WriteLine("Please enter size of array");
// int SizArr = Convert.ToInt32(Console.ReadLine());
// if(SizArr > 0){
//     int[] Arr = SetRandomArr(SizArr, 100, 999);
//     ShowArr(Arr);
//     Console.Write(" -> " + CountEvenElements(Arr));
// }

//Task 36 ------------------------------------------------------------
// to print the sum of array elements at odd positions
//
// int[] SetRandomArr(int size, int min, int max){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// int SumElemOddPos(int[] arr){
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(i % 2 != 0)
//             sum += arr[i];
//     }
//     return sum;
// }
// void ShowArr(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// Console.WriteLine("Please enter size of array");
// int SizArr = Convert.ToInt32(Console.ReadLine());
// if(SizArr > 0){
//     int[] Arr = SetRandomArr(SizArr, -99, 99);
//     ShowArr(Arr);
//     Console.Write(" -> " + SumElemOddPos(Arr));
// }

// Task 38 ------------------------------------------------------------
// to print the difference between max and min elements of array
//
// double[] SetRandomArr(int size, double min, double max){
//     double [] arr = new double[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().NextDouble() * (max - min);
//     }
//     return arr;
// }
// double DiffMaxMin(double[] arr){
//     double MinArr = arr[0];
//     double MaxArr = arr[0];
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] < MinArr) MinArr = arr[i];
//         if(arr[i] > MaxArr) MaxArr = arr[i];
//     }
//     return MaxArr - MinArr;
// }
// void ShowArr(double[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write("{0:f2} ", arr[i]);
//     }
// }
// Console.WriteLine("Please enter size of array");
// int SizArr = Convert.ToInt32(Console.ReadLine());
// if(SizArr > 0){
//     double[] Arr = SetRandomArr(SizArr, -99, 99);
//     ShowArr(Arr);
//     Console.Write("-> ");
//     Console.Write("{0:f2}", DiffMaxMin(Arr));
// }

//Task 35 ------------------------------------------------------------
// to print the number of array elements in the range [10-99]
//
// int [] SetRandomArr(int size, int min, int max){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(min,max+1);
//     }
//     return arr;
// }
// int CountElements(int[] arr, int MinArr, int MaxArr){
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] >= MinArr && arr[i] <= MaxArr)
//             count += 1;
//     }
//     return count;
// }
// void ShowArr(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
// }
// int[] arr = SetRandomArr(123, 0, 200);
// ShowArr(arr);
// Console.Write(" -> " + CountElements(arr, 10, 99));

//
//Task 37 ------------------------------------------------------------
// to calculate the product of pairs of array elements
//
int[] SetRandomArr(int size, int min, int max){
    int [] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(min,max+1);
    }
    return arr;
}
int[] PairsProd(int[] Arr){
    int SizArr = Arr.Length;
    int SizProdArr = SizArr / 2 + SizArr % 2;
    int[] ProdArr = new int[SizProdArr];
    for(int i = 0, j = SizArr-1; i < SizProdArr; i++, j--){
        if(i == j) ProdArr[i] = Arr[i];
        else ProdArr[i] = Arr[i] * Arr[j];
    }
    return ProdArr;
}
void ShowArr(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}
Console.WriteLine("Please enter size of array");
int SizArr = Convert.ToInt32(Console.ReadLine());
if(SizArr > 0){
    int[] Arr = SetRandomArr(SizArr, 1, 9);
    ShowArr(Arr);
    Console.Write("-> ");
    ShowArr(PairsProd(Arr));
}
