// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateMatrix(int n, int m){
    int[,] matrix = new int[n,m];
    for(int i=0; i<n;i++){
        for(int j=0; j<m;j++){
            int x = new Random().Next(0,100);
            matrix[i,j]=x;
            Console.Write(matrix[i,j]+" ");
        }Console.WriteLine();
    }
    
    return matrix;
}
void AverageMatrix(int[,] matrix){
    for(int i=0; i< matrix.GetLength(0);i++){
        double avg=0;
        for(int j=0; j<matrix.GetLength(1);j++){
            avg+=matrix[j,i];
        }
        Console.WriteLine("Среднее арифмитическое столбца "+(i+1)+" равно "+avg/matrix.GetLength(0));
    }
}
AverageMatrix(CreateMatrix(4,4));