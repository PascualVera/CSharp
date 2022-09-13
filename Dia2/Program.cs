using System;
using static System.Console;
//Ejercicio 1
string name = ReadLine();
string surname = ReadLine();
string age = ReadLine();

Console.WriteLine($"My name is {name} {surname} and I'm {age} y/o");
//Ejercicio 2

//Coche
int puertas;
int ruedas;
string marca;
bool itvVigente;

//Mesa
float peso;
float largo;
string material;
string color;

//Ejercico 3

int number = 5;
char letter = 'a';

WriteLine(number >= 18);
WriteLine(letter.GetType() == typeof(char));
WriteLine(number >= 18 && letter.GetType() == typeof(char));
WriteLine(number >= 18 || letter.GetType() == typeof(char));