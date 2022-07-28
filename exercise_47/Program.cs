// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
Console.WriteLine("Введите размерность двумерного массива   m x n");
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
double[,] array= new double [m,n];
Random random = new Random();
for(int i=0;i<m;i++){
    for (int j=0;j<n;j++){
        array[i,j]= random.NextDouble()*100;
        Console.Write("{0,6:F2}", array[i,j]);
    }
    Console.WriteLine();
}