//++++++++++++++++ЗАДАЧА №1 ++++++++++++++++++++
//генерируем и выводим массив
// double[,] array = GenerateArray(3, 4);
// Console.WriteLine("Исходный массив:");
// PrintArray(array);
// // Упорядочиваем элементы каждой строки по убыванию
// SortRowsDescending(array);
// // Выводим отсортированный массив
// Console.WriteLine("\nОтсортированный массив:");
// PrintArray(array);

// // генерация массива рандомом
// double[,] GenerateArray(int M, int N) {
//     Random random = new Random();
//     double[,] array = new double[M, N];
//     for (int i = 0; i < M; i++) {
//       for (int j = 0; j < N; j++) {
//         array[i, j] = Math.Round(random.NextDouble() * 20 - 10, 2); // случайное число от -10 до 10
//       }
//     }
//     return array;
//   }

// // метод печати массива
// void PrintArray(double[,] array) {
//         int M = array.GetLength(0);
//     int N = array.GetLength(1);
//     for (int i = 0; i < M; i++) {
//         for (int j = 0; j < N; j++) {
//             Console.Write(array[i, j] + "\t");
//       }
//       Console.WriteLine();
//     }
// }
// // метод сортировки массива по убыванию
// void SortRowsDescending(double[,] array) {
//     int M = array.GetLength(0);
//     int N = array.GetLength(1);
//     for (int i = 0; i < M; i++) {
//       for (int j = 0; j < N - 1; j++) {
//         for (int k = 0; k < N - j - 1; k++) {
//           if (array[i, k] < array[i, k + 1]) {
//             double temp = array[i, k];
//             array[i, k] = array[i, k + 1];
//             array[i, k + 1] = temp;
//           }
//         }
//       }
//     }
//   }

//++++++++++++++++ЗАДАЧА №2 ++++++++++++++++++++
// int[,] array = GenerateArray(10, 4);
// Console.WriteLine("Исходный массив:");
// PrintArray(array);
// int[] uniqueElements;
// int[] elementCounts;

// CreateFrequencyArrays(array, out uniqueElements, out elementCounts);

// Console.WriteLine("\nЧастота элементов:");
// for (int i = 0; i < uniqueElements.Length; i++) {
//     Console.WriteLine($"Элемент {uniqueElements[i]} встречается {elementCounts[i]} раз");
// }
    
// int[,] GenerateArray(int M, int N) {
//     Random random = new Random();
//     int[,] array = new int[M, N];
//     for (int i = 0; i < M; i++) {
//         for (int j = 0; j < N; j++) {
//             array[i, j] = random.Next(-5, 6);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array) {
//     int M = array.GetLength(0);
//     int N = array.GetLength(1);
//     for (int i = 0; i < M; i++) {
//         for (int j = 0; j < N; j++) {
//             Console.Write(array[i, j] + "\t");
//         }
//     Console.WriteLine();
// }
// }

// void CreateFrequencyArrays(int[,] array, out int[] uniqueElements, out int[] elementCounts) {
//     int M = array.GetLength(0);
//     int N = array.GetLength(1);
//     uniqueElements = new int[0];
//     elementCounts = new int[0];
//     for (int i = 0; i < M; i++) {
//         for (int j = 0; j < N; j++) {
//             int element = array[i, j];
//             int index = Array.IndexOf(uniqueElements, element);
//             if (index != -1) {
//                 elementCounts[index]++;
//             } else {
//                 int newSize = uniqueElements.Length + 1;
//                 Array.Resize(ref uniqueElements, newSize);
//                 Array.Resize(ref elementCounts, newSize);
//                 uniqueElements[newSize - 1] = element;
//                 elementCounts[newSize - 1] = 1;
//             }
//         }
//     }
// }
//++++++++++++++++ЗАДАЧА №3 ++++++++++++++++++++

// Console.Write("Введите количество строк матрицы A: ");
// int aRows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы A: ");
// int aCols = int.Parse(Console.ReadLine());

// int[,] matrixA = ReadMatrix(aRows, aCols, "A");

// Console.Write("Введите количество строк матрицы B: ");
// int bRows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы B: ");
// int bCols = int.Parse(Console.ReadLine());

// int[,] matrixB = ReadMatrix(bRows, bCols, "B");

// Console.WriteLine("\nМатрица A:");
// PrintMatrix(matrixA);

// Console.WriteLine("\nМатрица B:");
// PrintMatrix(matrixB);

// if (aCols != bRows) {
//     Console.WriteLine("\nКоличество столбцов матрицы A должно быть равно количеству строк матрицы B. Умножение невозможно.");
// } else {
//     int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);
//     Console.WriteLine("\nПроизведение матриц A и B:");
//     PrintMatrix(productMatrix);
// }

// int[,] ReadMatrix(int rows, int cols, string name) {
//     int[,] matrix = new int[rows, cols];
//     Console.WriteLine($"Введите элементы матрицы {name}:");
//     for (int i = 0; i < rows; i++) {
//         for (int j = 0; j < cols; j++) {
//             Console.Write($"[{i + 1}, {j + 1}]: ");
//             matrix[i, j] = int.Parse(Console.ReadLine());
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix) {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     for (int i = 0; i < rows; i++) {
//         for (int j = 0; j < columns; j++) {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB) {
//     int aRows = matrixA.GetLength(0);
//     int aCols = matrixA.GetLength(1);
//     int bRows = matrixB.GetLength(0);
//     int bCols = matrixB.GetLength(1);

//     int[,] product = new int[aRows, bCols];
//     for (int i = 0; i < aRows; i++) {
//         for (int j = 0; j < bCols; j++) {
//             int sum = 0;
//             for (int k = 0; k < aCols; k++) {
//                 sum += matrixA[i, k] * matrixB[k, j];
//             }
//             product[i, j] = sum;
//         }
//     }

//     return product;
// }
//++++++++++++++++ЗАДАЧА №4 ++++++++++++++++++++
// // задаем размерность массива 3х3
// int[,,] unique3DArray = GenerateUnique3DArray(3, 3, 3);

// Print3DArray(unique3DArray);
// // создаем случайный массив x y z 
// int[,,] GenerateUnique3DArray(int x, int y, int z) {
//     int[,,] array = new int[x, y, z];
//     List<int> uniqueNumbers = Enumerable.Range(10, 90).ToList();
//     Random random = new Random();

//     for (int i = 0; i < x; i++) {
//         for (int j = 0; j < y; j++) {
//             for (int k = 0; k < z; k++) {
//                 int index = random.Next(uniqueNumbers.Count);
//                 array[i, j, k] = uniqueNumbers[index];
//                 uniqueNumbers.RemoveAt(index);
//             }
//         }
//     }
//     return array;
// }
// // печатаем массив
// void Print3DArray(int[,,] array) {
//     int x = array.GetLength(0);
//     int y = array.GetLength(1);
//     int z = array.GetLength(2);

//     for (int i = 0; i < x; i++) {
//         for (int j = 0; j < y; j++) {
//             for (int k = 0; k < z; k++) {
//                 Console.Write($"[{i}, {j}, {k}] = {array[i, j, k]}\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
//++++++++++++++++ЗАДАЧА №5 ++++++++++++++++++++
// // спирально заполняем массив 4х4
// int[,] spiralArray = GenerateSpiralArray(4, 4);

// PrintArray(spiralArray);
// // генерируем массив спирально
// int[,] GenerateSpiralArray(int rows, int cols) {
//     int[,] array = new int[rows, cols];
//     int num = 1;
//     int row = 0;
//     int col = 0;
//     int rowStep = 0;
//     int colStep = 1;

//     for (int i = 0; i < rows * cols; i++) {
//         array[row, col] = num++;
//         if (row + rowStep >= rows || row + rowStep < 0 || col + colStep >= cols || col + colStep < 0 || array[row + rowStep, col + colStep] != 0) {
//             int temp = rowStep;
//             rowStep = colStep;
//             colStep = -temp;
//         }
//         row += rowStep;
//         col += colStep;
//     }
//     return array;
// }
// // выводим массив
// void PrintArray(int[,] array) {
//     int rows = array.GetLength(0);
//     int cols = array.GetLength(1);
//     for (int i = 0; i < rows; i++) {
//         for (int j = 0; j < cols; j++) {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
