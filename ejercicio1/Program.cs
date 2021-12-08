using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1. Jugando con operadores

● De manera libre el estudiante debe crear un algoritmo que haga uso de los
diferentes operadores existentes. Se espera que cree un método en el que
se haga uso de los diferentes tipos de operadores:
o Operadores unitarios: -, +, --, ++ 

o Operador de asignación: = (en este método se espera que el
estudiante haga uso de declaraciones compuestas del tipo +=, -=,
*=, /=, %=).
o Operadores relacionales: ==, !=, <, <=, >=.
o Operadores lógicos: &&, ||.
o Operador ternario: condición ? if true : if false.

*/
char operacion=' ';
int numero1;
int numero2;
int resultado=0;
int resultado2=0;
int cont=0;

Console.WriteLine("Digita el primer numero:");
numero1=int.Parse(Console.ReadLine());
Console.WriteLine("Digita el segundo numero:");
numero2=int.Parse(Console.ReadLine());


Console.WriteLine("que quieres?");
Console.WriteLine("restar: (-)");
Console.WriteLine("sumar: (-)");

operacion=char.Parse(Console.ReadLine());

while(cont !=0){

switch (operacion)
{
    case '+':
   resultado=numero1+numero2;
   cont++;
    break;
    case '-':
resultado=numero1-numero2;
cont++;
    break;    

    default:
    
    break;
}

}
cont=10;
if (numero1>=10 && numero2>=10)
    {
        for (int i = 0; i < cont; i++)
        {
          resultado2+=cont;
          cont--;  
        }
        
    }
    else if(numero1<=8 || numero2<=4)

    {
        resultado2*=numero1+numero2;
    }

    Console.WriteLine($"el primer resultado fue: {resultado}");
    Console.WriteLine($"el segundo resultado fue: {resultado2}");





        }
    }
}
