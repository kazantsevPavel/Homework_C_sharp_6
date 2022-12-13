// задача 1 - HARD необязательная. На вход программы подаются одно целое число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов. Это по сути последовательность Негафибоначчи.
// Пример:
// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

Console.WriteLine("Введите число");
int n = Convert.ToInt32 (Console.ReadLine()); 

int[] fibonacci =new int [2*n+1];
fibonacci[n] = 0;
fibonacci[n+1] = 1;
fibonacci[n-1] = 1;

for (int i =n+1; i<fibonacci.Length; i++)
fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];

for (int i = n-2; i>-1; i--)
fibonacci[i] = fibonacci[i+2] - fibonacci[i+1];

foreach (int el in fibonacci)
{
    Console.Write(el + ", ");
}