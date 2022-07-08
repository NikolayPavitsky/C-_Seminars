// Seminar 05.07.22
//
double [,] GetArray2dDbl(int row, int col, int min, int max)
{
    double[,] result = new double[row,col];
    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min) + min;
        }
    }
    return result;
}
int [,] GetArray2dInt(int row, int col, int min, int max)
{
    int[,] result = new int[row,col];
    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray2dDbl(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}
void PrintArray2dInt(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray1dInt(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.WriteLine();
}
int [,] ChangeArray(int[,] arr)
{
    int lastRow = arr.GetLength(0)-1;
    int lastCol = arr.GetLength(1);
    for (int i = 0; i < lastCol; i++)
    {
        int buf = arr[0,i];
        arr[0,i]=arr[lastRow,i];
        arr[lastRow,i]=buf;
    }
    return arr;
}
int [,] SwapRowsColumns(int[,] arr)
{
    int num = arr.GetLength(0);
    int[,] buff = new int[num,num];
    for (int i = 0; i < num; i++)
    {
        for (int j = 0; j < num; j++)
        {
            buff[j,i]=arr[i,j];
        }
    }
    return buff;
}
int[] GetArray1dFrom2d(int[,] array2d)
{
    int[] array1d = new int[array2d.GetLength(0) * array2d.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array1d[k] = array2d[i,j];
            k++;
        }
    }
    return array1d;
}
void SortArray1dInt(int[] array, bool sortAscend)
{
    int buff =0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if(sortAscend)
            {
                if(array[i] > array[j])
                {
                    buff = array[i];
                    array[i] = array[j];
                    array[j] = buff;
                }
            }
            else
            {
                if(array[i] < array[j])
                {
                    buff = array[i];
                    array[i] = array[j];
                    array[j] = buff;
                }
            }            
        }
    }
}
void FrequencyDictionary(int[] array)
{
    int count =1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] != element)
        {
            Console.WriteLine($"{element} is contained {count} times");
            element = array[i];
            count = 1;
        }
        else count++;
    }
    Console.WriteLine($"{element} is contained {count} times");
}
int[] GetMinArr2d(int[,] array)
{
    int[] ijIndex = new int[2];
    int min =array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i,j];
                ijIndex[0]=i;
                ijIndex[1]=j;
            }
        }
    }
    return ijIndex;
}
int[,] ModifyArr2d(int[,] array, int[] ijIndex)
{
    int[,] arrayMod = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int imod = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i != ijIndex[0])
        {
            imod++;
            int jmod = -1;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(j != ijIndex[1])
                {
                    jmod++;
                    arrayMod[imod,jmod] = array[i,j];
                }
            }

        }
    }
    return arrayMod;
}
//
// Task 53
// To change first and last lines
//
// Console.Clear();
// Console.Write("Please enter number of rows in array   ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in array   ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray2dInt(rows, columns, 0, 10);
// Console.WriteLine("array before");
// PrintArray2dInt(array);
// Console.WriteLine("array after changing first and last lines");
// PrintArray2dInt(ChangeArray(array));
//
// Task 55
// To replace rows with columns
//
// Console.Clear();
// Console.Write("Please enter number of rows in array   ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in array   ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray2dInt(rows, columns, 0, 10);
// Console.WriteLine("array before");
// PrintArray2dInt(array);
// if(rows == columns)
// {
//     Console.WriteLine("array after swap");
//     PrintArray2dInt(SwapRowsColumns(array));
// }
// else Console.WriteLine("Number of rows is not equal to the number of columns. Please try again");
//
// Task 57
// To compile the frequency dictionary of elements of 2d array
//
// Console.Clear();
// Console.Write("Please enter number of rows in array   ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in array   ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array2d = GetArray2dInt(rows, columns, 0, 10);
// int[] array1d = GetArray1dFrom2d(array2d);

// Console.WriteLine("array before");
// PrintArray2dInt(array2d);
// Console.WriteLine(String.Join(" ", array1d));
// bool sortAscend = true; // sort ascending
// SortArray1dInt(array1d, sortAscend);
// Console.WriteLine(String.Join(" ", array1d));
// FrequencyDictionary(array1d);
//
// Task 57
// To remove the row and column at the intersection of which
//  the smallest element of the array is located.
//
// Console.Clear();
// Console.Write("Please enter number of rows in array   ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in array   ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array2d = GetArray2dInt(rows, columns, 0, 10);

// Console.WriteLine("array before");
// PrintArray2dInt(array2d);

// int[] indicesIJ = GetMinArr2d(array2d);
// Console.WriteLine("indexes of the smallest array element: i=" + indicesIJ[0] + " and j=" + indicesIJ[1]);

// Console.WriteLine("array after modification");
// PrintArray2dInt(ModifyArr2d(array2d, indicesIJ));

//
// Home work 07.07.22
//
// Task 54
// To sort lines of 2d array
//
// Console.Clear();
// Console.Write("Please enter number of rows in array   ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in array   ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array2d = GetArray2dInt(rows, columns, 0, 10);

// Console.WriteLine("array before");
// PrintArray2dInt(array2d);

// int[] buf = new int[array2d.GetLength(1)];
// bool sortAscend = false; // sort descending
// for (int i = 0; i < array2d.GetLength(0); i++)
// {
//     for (int j = 0; j < array2d.GetLength(1); j++)
//     {
//         buf[j] = array2d[i,j];
//     }
//     SortArray1dInt(buf, sortAscend);
//     for (int j = 0; j < array2d.GetLength(1); j++)
//     {
//         array2d[i,j] = buf[j];
//     }    
// }
// Console.WriteLine("array after sorting of each line");
// PrintArray2dInt(array2d);

//
// Task 56
// To find the row with the smallest sum of array elements
//
// void PrintRowMinSum(int[,] array2d)
// {
//     int iMin = 0;
//     int sumMin = 0;
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             sum += array2d[i,j];
//         }
//         if(i==0)
//         {
//             sumMin = sum;
//             iMin = i;
//         }
//         else
//         {
//             if(sum < sumMin)
//             {
//                 sumMin = sum;
//                 iMin = i;
//             }
//         }
//     }
//         for(int j = 0; j < array2d.GetLength(1); j++){
//         Console.Write(array2d[iMin,j] + " ");
//     }
// }

// Console.Clear();
// int rows = 4;
// int columns = 5;
// int[,] array2d = GetArray2dInt(rows, columns, 0, 10);

// Console.WriteLine("2d array is");
// PrintArray2dInt(array2d);
// Console.WriteLine("row with the smallest sum of array elements is");
// PrintRowMinSum(array2d);

//
// Task 58
// To find the product of two matrices
//

// int[,] GetProductMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 product[i,j] += matrix1[i,k] * matrix2[k,j];    
//             }            
//         }        
//     }
//     return product;
// }

// Console.Clear();
// Console.Write("Please enter number of rows in 1st matrix   ");
// int rows1 = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in 1st matrix   ");
// int columns1 = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of rows in 2nd matrix   ");
// int rows2 = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in 2nd matrix   ");
// int columns2 = int.Parse(Console.ReadLine());
// if(columns1 == rows2)
// {
//     int[,] matrix1 = GetArray2dInt(rows1, columns1, 0, 10);
//     int[,] matrix2 = GetArray2dInt(rows2, columns2, 0, 10);
//     Console.WriteLine("1st matrix is");
//     PrintArray2dInt(matrix1);
//     Console.WriteLine("2nd matrix is");
//     PrintArray2dInt(matrix2);
//     Console.WriteLine("Product of two matrices is");
//     PrintArray2dInt(GetProductMatrix(matrix1, matrix2));
// }
// else
// {
//     Console.WriteLine("The number of columns of the first matrix is not equal to the number of rows of the second");
//     Console.WriteLine("Please tray again");
// }
//

//
// Task 60
// To print 3d array
//
// bool DublicatedValuesFound(int [,,] array, int val, int rows, int columns, int slabs)
// {
//     for (int i = 0; i <= rows; i++) 
//     {
//         for (int j = 0; j <= columns; j++)
//         {
//             for (int k = 0; k <= slabs; k++)
//             {
//                 if(array[i,j,k] == val) return true;
//             }            
//         }
//     }
//     return false;
// }
// int [,,] GetArray3dInt(int rows, int columns, int slabs, int min, int max)
// {
//     int[,,] result = new int[rows,columns,slabs];
//     for (int i = 0; i < rows; i++) 
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < slabs; k++)
//             {
//                 int val = -1;
//                 result[i, j, k] = val; // initial value
//                 bool test = true;
//                 while(test)
//                 {
//                     val = new Random().Next(min, max + 1); // random value
//                     test = DublicatedValuesFound(result, val, i, j, k);
//                 }
//                 result[i, j, k] = val;               
//             }            
//         }
//     }
//     return result;
// }
// void PrintArray3dInt(int[,,] inArray)
// {
//     for (int k = 0; k < inArray.GetLength(2); k++)
//     {
//         for (int i = 0; i < inArray.GetLength(0); i++)
//         {
//             Console.WriteLine("Row for i="+i+" and k="+k);
//             for (int j = 0; j < inArray.GetLength(1); j++)
//             {
//                 Console.Write($"{inArray[i,j,k]} ");
//             }
//             Console.WriteLine();
//         }
            
//     }
// }

// Console.Clear();
// Console.Write("Please enter number of rows in the array   ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of columns in the array   ");
// int columns = int.Parse(Console.ReadLine());
// Console.Write("Please enter number of slabs in the array   ");
// int slabs = int.Parse(Console.ReadLine());
// int[,,] array3d = GetArray3dInt(rows, columns, slabs, 10, 99);
// PrintArray3dInt(array3d);
//

//
// Task 61
// To print the Pascal's triangle
//
// void PascalTriangle(int nRows)
// {
//     for (int y = 0; y < nRows; y++)
//     {
//         int val = 1;
//         for (int blank = 0; blank < nRows - y; blank++)
//         {
//             Console.Write("   ");
//         }
//         for (int x = 0; x <= y; x++)
//         {
//             Console.Write("    {0:D} ", val);
//             val = val * (y - x) / (x + 1);
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Please enter number of rows in Pascal's triangle   ");
// int rows = int.Parse(Console.ReadLine());
// PascalTriangle(rows);

//
// Task 62
// To fill the 2d array of any size in a spiral
//
void FillArray(int[,] array, int row, int col, int val, int dir){
    if(array[row, col] == 0){
        val += 1;
        array[row, col] = val;
        if(dir==1)
        {
            if(col < array.GetLength(1)-1)
            {
                if(array[row,col+1] == 0) 
                    FillArray(array, row, col+1, val, dir);
                else
                {
                    ChangeDirection(dir, row, col, val, array);
                }
            }           
            else
            {
                ChangeDirection(dir, row, col, val, array);
            } 
        }
        else if(dir==2)
        {
            if(row < array.GetLength(0)-1)
            {
                if(array[row+1,col] == 0)
                {
                    FillArray(array, row+1, col, val, dir);
                }
                else
                {
                    ChangeDirection(dir, row, col, val, array);
                } 
            }            
            else
            {
                ChangeDirection(dir, row, col, val, array);
            } 
        }
        else if(dir==3)
        {
            if(col > 0)
            {
                if(array[row,col-1] == 0)
                {
                    FillArray(array, row, col-1, val, dir);
                }
                else
                {
                    ChangeDirection(dir, row, col, val, array);
                } 
            }
            else
            {
                ChangeDirection(dir, row, col, val, array);
            } 
        }
        else
        {
            if(row > 0)
            {
                if(array[row-1,col] == 0)
                {
                    FillArray(array, row-1, col, val, dir);
                }
                else
                {
                    ChangeDirection(dir, row, col, val, array);
                } 
            }
            else
            {
                ChangeDirection(dir, row, col, val, array);
            } 
        }
    }
}
void ChangeDirection(int dir, int row, int col, int val, int [,] array)
{
    if(dir==1)
    {
        if(row < array.GetLength(0)-1)
        {
            if(array[row+1,col] == 0)
                FillArray(array, row+1, col, val, 2);
        }
        else if(col > 0)
        {
            if(array[row,col-1] == 0)
                FillArray(array, row, col-1, val, 3);
        }
        else if(row > 0)
        {
            if(array[row-1,col] == 0)
                FillArray(array, row-1, col, val, 4);
        }
    }
    else if(dir ==2)
    {
        if(col > 0)
        {
            if(array[row,col-1] == 0)
                FillArray(array, row, col-1, val, 3);

        }
        else if(row > 0)
        {
            if(array[row-1,col] == 0)
                FillArray(array, row-1, col, val, 4);
        }
        else if(col < array.GetLength(1)-1)
        {
            if(array[row,col+1] == 0) 
                FillArray(array, row, col+1, val, 1);

        }        
    }
    else if(dir ==3)
    {
        if(row > 0)
        {
            if(array[row-1,col] == 0)
                FillArray(array, row-1, col, val, 4);
        }
        else if(col < array.GetLength(1)-1)
        {
            if(array[row,col+1] == 0) 
                FillArray(array, row, col+1, val, 1);

        }        
        else if(row < array.GetLength(0)-1)
        {
            if(array[row+1,col] == 0)
                FillArray(array, row+1, col, val, 2);
        }      
    }
    else
    {
        if(col < array.GetLength(1)-1)
        {
            if(array[row,col+1] == 0) 
                FillArray(array, row, col+1, val, 1);

        }        
        else if(row < array.GetLength(0)-1)
        {
            if(array[row+1,col] == 0)
                FillArray(array, row+1, col, val, 2);
        }      
        else if(col > 0)
        {
            if(array[row,col-1] == 0)
                FillArray(array, row, col-1, val, 3);

        }
    }
}
//
Console.Clear();
Console.WriteLine("filling 2d array of any size in a spiral");
Console.Write("Please enter number of rows in the array   ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Please enter number of columns in the array   ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
// set initial values
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = 0;
    }    
}
Console.WriteLine("filled array is");
int val = 0;
int dir = 1;
FillArray(array, 0, 0, val, dir);
PrintArray2dInt(array);

