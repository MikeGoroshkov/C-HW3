﻿//Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве. 
//A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());
double delta = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.WriteLine("Расстояние между точками = " + delta);
