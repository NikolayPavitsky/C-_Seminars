// Seminar 01.07.22
// Case 1
// To create 2d array
// int[,] CreateRandomArray(int RowSize, int ColSize, int Min, int Max){
//     int [,] array = new int[RowSize,ColSize];
//     for(int i = 0; i < RowSize; i++){
//         for(int j = 0; j < ColSize; j++){
//             array[i,j] = new Random().Next(Min, Max + 1);
//         }
//     }
//     return array;
// }
// void ShowRandomArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// //
// Console.WriteLine("Enter number of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums: ");
// int Colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myRandomarray = CreateRandomArray(Rows, Colums, min, max);
// ShowRandomArray(myRandomarray);
// Console.WriteLine();
//
// Case 2
//
// int[,] CreateArray(int RowSize, int ColSize){
//     int [,] array = new int[RowSize,ColSize];
//     for(int i = 0; i < RowSize; i++){
//         for(int j = 0; j < ColSize; j++){
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }
// void ShowArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// //
// Console.WriteLine("Enter number of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums: ");
// int Colums = Convert.ToInt32(Console.ReadLine());
// int[,] myarray = CreateArray(Rows, Colums);
// ShowArray(myarray);
// Console.WriteLine();
//
// Case 3
//
// int[,] CreateRandomArray(int RowSize, int ColSize, int Min, int Max){
//     int [,] array = new int[RowSize,ColSize];
//     for(int i = 0; i < RowSize; i++){
//         for(int j = 0; j < ColSize; j++){
//             array[i,j] = new Random().Next(Min, Max + 1);
//         }
//     }
//     return array;
// }
// int[,] ChangeArray(int[,] array, int RowSize, int ColSize){
//     for(int i = 2; i < RowSize; i++){
//         for(int j = 2; j < ColSize; j++){
//             if(i % 2 == 0 || j % 2 == 0) array[i,j] *= array[i,j];
// //            if(i % 2 == 0 && j % 2 == 0)) array[i,j] *= array[i,j];

//         }
//     }
//     return array;
// }
// void ShowRandomArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter number of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums: ");
// int Colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myRandomarray = CreateRandomArray(Rows, Colums, min, max);
// ShowRandomArray(myRandomarray);
// Console.WriteLine();
// ChangeArray(myRandomarray, Rows, Colums);
// ShowRandomArray(myRandomarray);
//
// Case 4
//
// int[,] CreateRandomArray(int RowSize, int ColSize, int Min, int Max){
//     int [,] array = new int[RowSize,ColSize];
//     for(int i = 0; i < RowSize; i++){
//         for(int j = 0; j < ColSize; j++){
//             array[i,j] = new Random().Next(Min, Max + 1);
//         }
//     }
//     return array;
// }
// int SumNumber(int[,] array){
//     int sum = 0;
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(i == j) sum += array[i,j];
//         }
//     }
//     return sum;
// }
// void ShowRandomArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter number of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums: ");
// int Colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myRandomarray = CreateRandomArray(Rows, Colums, min, max);
// ShowRandomArray(myRandomarray);
// Console.WriteLine();
// Console.WriteLine("sum is " + SumNumber(myRandomarray));

//
// Home work 05.07.22
//

// Task 47
// To create 2d array
//
// double[,] CreateRandomDblArray(int RowSize, int ColSize, double Min, double Max){
//     double [,] array = new double[RowSize,ColSize];
//     for(int i = 0; i < RowSize; i++){
//         for(int j = 0; j < ColSize; j++){
//             array[i,j] = new Random().NextDouble() * (Max - Min) + Min;
//         }
//     }
//     return array;
// }
// void ShowRandomArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write("{0:f1} ", array[i,j]);
//         }
//     Console.WriteLine();
//     }
// }
// //
// Console.WriteLine("Enter number of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums: ");
// int Colums = Convert.ToInt32(Console.ReadLine());
// double[,] myRandomarray = CreateRandomDblArray(Rows, Colums, -10, 10);
// ShowRandomArray(myRandomarray);
// Console.WriteLine();

// Task 50
// To write one element of 2d array
//
// int[,] CreateRandomArray(int RowSize, int ColSize, int Min, int Max){
//     int [,] array = new int[RowSize,ColSize];
//     for(int i = 0; i < RowSize; i++){
//         for(int j = 0; j < ColSize; j++){
//             array[i,j] = new Random().Next(Min, Max + 1);
//         }
//     }
//     return array;
// }
// void ShowRandomArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// //
// Console.WriteLine("Enter index of rows: ");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter index of colums: ");
// int Colums = Convert.ToInt32(Console.ReadLine());
// int min = 0;
// int max = 10;
// int[,] myRandomArray = CreateRandomArray(4, 3, min, max);
// ShowRandomArray(myRandomArray);
// Console.Write($"{Rows},{Colums} -> ");
// if(Rows >= myRandomArray.GetLength(0) || Colums >= myRandomArray.GetLength(1))
//     Console.Write("there is no such number in the array");
// else
//     Console.Write(myRandomArray[Rows, Colums]);


// Task 52
// To find the arithmetic mean of the elements in each column of 2d array
//
int[,] CreateRandomArray(int RowSize, int ColSize, int Min, int Max){
    int [,] array = new int[RowSize,ColSize];
    for(int i = 0; i < RowSize; i++){
        for(int j = 0; j < ColSize; j++){
            array[i,j] = new Random().Next(Min, Max + 1);
        }
    }
    return array;
}
void ShowRandomArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}
void Show1dArray(double[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write("{0:f1} ", array[i]);
    }
}
//
Console.WriteLine("Enter number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of colums: ");
int Colums = Convert.ToInt32(Console.ReadLine());
int[,] myRandomArray = CreateRandomArray(Rows, Colums, 0, 10);
ShowRandomArray(myRandomArray);
double [] RowArray = new double[myRandomArray.GetLength(1)];
for(int j = 0; j < myRandomArray.GetLength(1); j++){
    RowArray[j] = 0;
    for(int i = 0; i < myRandomArray.GetLength(0); i++){
        RowArray[j] += myRandomArray[i,j];
    }
    RowArray[j] /= myRandomArray.GetLength(0);
}
Console.WriteLine("arithmetic mean of the elements in column: ");
Show1dArray(RowArray);
