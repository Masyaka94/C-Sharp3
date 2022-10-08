/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/
int x1,y1,z1,
x2, y2, z2;
Console.WriteLine($"Vvedite koordinatu pervoi tochki x1");
int.TryParse(Console.ReadLine(),out x1);
Console.WriteLine($"Vvedite koordinatu pervoi tochki y1");
int.TryParse(Console.ReadLine(),out y1);
Console.WriteLine($"Vvedite koordinatu pervoi tochki z1");
int.TryParse(Console.ReadLine(),out z1);

Console.WriteLine($"Vvedite koordinatu vtoroi tochki x2");
int.TryParse(Console.ReadLine(),out x2);
Console.WriteLine($"Vvedite koordinatu vtoroi tochki y2");
int.TryParse(Console.ReadLine(),out y2);
Console.WriteLine($"Vvedite koordinatu vtoroi tochki z2");
int.TryParse(Console.ReadLine(),out z2);

double Rasstoyanie_mezchdu_tochkami = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точкой 1 с координатами {x1}.{y1}.{z1} и точкой 2 с координатами {x2}.{y2}.{z2} равно");
Console.WriteLine($"{Rasstoyanie_mezchdu_tochkami}");