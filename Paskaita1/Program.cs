//Pirma uzduotis : Staciakampio ploto ir perimetro skaiciuokle

/*
using System;

Console.WriteLine("Staciakampio ploto ir perimetro skaiciuokle");
Console.WriteLine("Irasykite staciakampio krastines ilgi ");

int x = int.Parse(Console.ReadLine());

int plotas = x * x;

int perimetras = x * 4;

Console.WriteLine("Staciakampio plotas");
Console.WriteLine(plotas);

Console.WriteLine("Staciakampio perimetras");
Console.WriteLine(perimetras);

*/

// Antra uzduotis : Apskritimo ilgio (perimetro?), ploto ir skersmens skaiciavimai (pi 3.12)
/*
using System;

Console.WriteLine("Apskritimo savybiu skaciavimai pagal spinduli");
Console.WriteLine("Iveskite spindulio ilgi");

double spindulys = double.Parse(Console.ReadLine());

double perimetras = 2 * spindulys * 3.14;
double plotas = 4 * 3.14 * spindulys * spindulys;
double skersmuo = 2 * spindulys;

Console.WriteLine("Skersmuo:");
Console.WriteLine(skersmuo);

Console.WriteLine("plotas:");
Console.WriteLine(plotas);

Console.WriteLine("perimetras:");
Console.WriteLine(perimetras);

//Trecia uzduotis : Trikampio perimetro skaiciavimai
*/
/*
using System;

Console.WriteLine("Trikampio perimetro skaiciavimas");
Console.WriteLine("Iveskite a,b ir c krastiniu ilgius ");
Console.WriteLine("a krastines ilgis ");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("b krastines ilgis ");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("c krastines ilgis ");

int c = int.Parse(Console.ReadLine());

int perimetras = a + b + c;


Console.Write("Trikampio perimetras ");
Console.WriteLine(perimetras);

*/

//Ketvirta uzduotis 
//Isvesti kubo turi ir pavirsiaus plota
/*
using System;


Console.WriteLine("Prasome irasyti kubo krastines ilgi ");
int a = int.Parse(Console.ReadLine());

int turis = a * a * a;
int pavirsiausPlotas = a * 6;

Console.WriteLine("Kubo turis - ");
Console.WriteLine(turis);
Console.WriteLine("Kubo pavirsiaus plotas - ");
Console.WriteLine(pavirsiausPlotas);
*/
//Penkta uzduotis 
//Staciakampio gretasienio turis ir pavirsiaus plotas 

/*

using System;

Console.WriteLine("Staciakampio gretasienio turio ir pavirsiaus ploto skaiciuotuvas");
Console.WriteLine("Iveskite krastines a ilgi");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite krastines b ilgi");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Iveskite kubo auksti h");
int h = int.Parse(Console.ReadLine());

int turis = a * b * h;
int pavirsiausPlotas = 2 * (a * b + a * h + b * h);
Console.WriteLine(turis);
Console.WriteLine(pavirsiausPlotas);

//4512

*/

//Sesta uzduotis Skaiciu formatavimas valiutos stiliumi

using System;

Console.WriteLine("Iveskite kaina su dviem skaiciais po kablelio");
double kaina = double.Parse(Console.ReadLine());

Console.WriteLine($"kaina: {kaina.ToString("F2")}€");


