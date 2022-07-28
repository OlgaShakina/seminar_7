// SЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
void CheckMatrix(int i, int j, int[,] matrix){
    if(i<matrix.GetLength(0)&& j<matrix.GetLength(1)&& i>=0&&j>=0){
        Console.WriteLine("По этому индексу лежит число " + matrix[i,j]);
    }
    else {Console.WriteLine("Не корректный ввод");
    }
}
Console.WriteLine("Введи индекс ячейки массива");
int i= Convert.ToInt32(Console.ReadLine());
int j= Convert.ToInt32(Console.ReadLine());
CheckMatrix(i, j, CreateMatrix(4,4));
