using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Ejercicio 4 Jugando con operaciones básicas

● Cree un algoritmo que dados dos números con decimales y un símbolo (+,
-, * y /), el cálculo correspondiente de acuerdo con el símbolo ingresado y
muestre en pantalla el resultado de la operación. Se debe crear un
método por cada uno de los símbolos u operaciones.
*/
double numero1;
double numero2;
double resultado=0;
char operacion=' ';
int cont=0;

Console.WriteLine("Digtia el primer numero:");
numero1=int.Parse(Console.ReadLine());
Console.WriteLine("Digtia el segundo numero:");
numero2=int.Parse(Console.ReadLine());

Console.WriteLine("Que operacion deseas realizar:");
Console.WriteLine("digita (+) si lo que deseas es una suma.");
Console.WriteLine("digita (*) si lo que quieres es una multiplicación. ");
Console.WriteLine("digita (-) si lo que quieres es una resta.");
Console.WriteLine("digita (/) si lo que quieres es una división");



while(cont==0)
{
operacion=char.Parse(Console.ReadLine());

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
    case '/':
     resultado=numero1/numero2;
     cont++;

    break;
    case '*':
     resultado=numero1*numero2;
     cont++;

    break;
    default:
    Console.WriteLine("Esa operacion no es valida, digita una operacion valida.");
    break;

}
}
Console.WriteLine($"el resultado de {numero1} {operacion} {numero2} es: {resultado}");

        }
    }
}
