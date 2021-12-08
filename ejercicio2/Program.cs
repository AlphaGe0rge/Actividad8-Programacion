using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Ejercicio 2. Recibiendo diferentes tipos de datos y utilizando funciones
● Escribir un algoritmo que permita ingresar y recibir información de una
persona por consola, la información que debe recibir es:
o Tipo de documento (a escoger).
o N.° de documento (entero).
o Nombre (string).
o Edad (entero).
o Sexo (char).
o Peso (double).
o Altura (a escoger).
● Se deben crear funciones o métodos que permita identificar:
o Si la persona es mayor de edad.
o Si la persona está en su peso ideal*/

int documento=0;
int N_documento;
string nombre;
int edad;
char sexo=' ';
double peso;
double altura;
double IMC;

Console.WriteLine("elige tu tipo de documento:"+"\n"+"digita uno (1) si es tarjeta de identidad y dos (2) si es cedula");
while ( documento !=1 && documento !=2 ){
documento=int.Parse(Console.ReadLine());
if(documento !=1 && documento !=2){
Console.WriteLine("ese no es un numero valido digita una de las dos opciones validas. uno si es tarjeta de identida y dos si es documento:");
}
}

Console.WriteLine("Digita tu numero de documento");
N_documento=int.Parse(Console.ReadLine());

Console.WriteLine("Escribe tu nombre:");
nombre=Console.ReadLine();

Console.WriteLine("Digita tu edad:");
edad=int.Parse(Console.ReadLine());

Console.WriteLine("Digita (M) si eres hombre y (F) si eres mujer: ");
while (sexo != 'm' && sexo != 'f'){
sexo=char.Parse(Console.ReadLine());
if (sexo != 'm' && sexo != 'f')
{
    Console.WriteLine("no digitastes una de las opciones disponibles. (m) si eres hombre o (f) si eres mujer");
}
}


Console.WriteLine("cuantos kilos pesas?");
peso=double.Parse(Console.ReadLine());

Console.WriteLine("Cuanto mides en metros?");
altura=double.Parse(Console.ReadLine());


Console.WriteLine("---------------------------------------------------------------------");

if(edad>17)
{
    Console.WriteLine($"{nombre} es mayor de edad");
}
else{
    Console.WriteLine($"{nombre} es menor de edad");
}
/*el IMC se calcula dividiendo la masa en kilogramos por la altura en metros elevado al cuadrado (m/a^2), esto nos dira si estamos en 
la el peso ideal o si estamos por encima o por debajo.

obesida --> IMS por encima de 30.0
Peso superior al normal --> IMS entre 25.0 y 29.9
peso normal --> IMS entre 18.5 y 24.9
peso por debajo del normal --> IMS por debajo de 18.5

*/
IMC=peso/Math.Pow(altura,2);


if (IMC < 18.5)
{
   Console.WriteLine($"{nombre}, tu IMC es de {IMC} por lo que estas por debajo de tu peso ideal"); 
}
else if (IMC >= 18.5 && IMC <=24.9){
    Console.WriteLine($"{nombre}, tu IMC es de {IMC} por lo que estas en tu peso ideal");

}
else if (IMC >= 25.0 && IMC <=29.9){
    Console.WriteLine($"{nombre}, tu IMCS es de {IMC} por lo que estas por encima de tu peso ideal");

}
else
{

    Console.WriteLine($"{nombre}, tu IMC es de {IMC} por lo que estas en etapa de obesidad");

}

        }
    }
}
