//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от N до M

int n, m, s=0;
Console.Write("Введи значение от N: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение до M: ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine(s);
