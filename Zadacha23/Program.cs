// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Vvedite chislo N");
int N = int.Parse(Console.ReadLine());

for (int chislo=1;chislo<=N;chislo++)
{
   Console.WriteLine($"Куб числа {chislo} равен - "+ Math.Pow(chislo,3));
}