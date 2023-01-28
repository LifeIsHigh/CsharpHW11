// Напишите цикл, который принимает на вход 2 числа (А и В)
// и возводит число А в натуральную степень В

Console.Write("Enter a value A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value B: ");
int B = Convert.ToInt32(Console.ReadLine());

int a = A;
for (int i = 1; i < B; i++)
{
    A = A * a;
}
Console.WriteLine(A);