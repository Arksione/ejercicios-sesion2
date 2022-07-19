//Ejercicio N°1
/*Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
 * usa una variable para cada dato y otra para el mensaje. 
 * Ej: nombre, apellido, edad, sabe programar, etc.*/

Console.WriteLine("Introduce tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce tu ciudad");
string ciudad = Console.ReadLine();
Console.WriteLine("Introduce tu lenguaje");
string lenguaje = Console.ReadLine();


Console.Write("Hola " + nombre);
Console.Write(". Tienes " + edad);
Console.Write(". Vives en " + ciudad);
Console.WriteLine(". Sabe programar " + lenguaje);

//Ejercicio N°2
/*Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
Coche: puertas, ruedas, marca, ITV vigente
Mesa: peso, largo, material, color
*/

int puertas = 4;
int ruedas = 4;
string marca = "Porsche";
string itv = "Vigente";
Console.WriteLine("El coche tiene " + puertas + " puertas, " + ruedas + " ruedas," + " es de la marca " + marca + " y tiene su ITV " + itv + ".");

int peso = 50;
float largo = 1.30f;
string material = "Pino oregon";
string color = "Beige";
Console.WriteLine("La mesa tiene un peso de " + peso + " kilos, " + largo + " metros de largo," + " hecha con madera de " + material + " y es de color " + color + ".");




//Ejercicio N°3
/*Operadores Determina los operadores para verificar las siguientes condiciones:
Un número es mayor o igual a 18
Un char es ‘a’
Se cumplen dos conciones a la vez (ambas verdaderas)
Se cumple una de dos condiciones a la vez (una true y otra false)*/

int a = 19;
int b = 17;
Console.WriteLine("Hay un numero mayor a 18? " + (a >= b));
char c = 'a';
char d = 'b';
Console.WriteLine("Que char hay? " + (c) );
int e = 4;
int f = 5;
Console.WriteLine("True true: " + (e > 3 && f < 6));
Console.WriteLine("True false: " + (e < 5 || f > 5));
Console.WriteLine("False true: " + (e > 4 || f > 6));
