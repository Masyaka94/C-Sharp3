/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/
Console.WriteLine("Vvedite pyatiznachnoe chislo a");
int a = int.Parse(Console.ReadLine());

int cifra1 = a/10000;
int cifra2 = (a%10000)/1000;
int cifra4 = (a%100)/10;
int cifra5 = (a%10);

if (cifra1 == cifra5 && cifra2 == cifra4)
{
        Console.WriteLine(a + " - палиндром");
}
else
{
            Console.WriteLine(a + " - палиндромом не является");
}