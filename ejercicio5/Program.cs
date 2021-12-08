using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 5. Jugando con operaciones básicas

● Cree un algoritmo que calcule el factorial de un valor numérico introducido
como parámetro o argumento en la línea de comandos.*/

int numero;
int factorial=1;
int cont=0;


Console.WriteLine("Digite el numero al que le deseas encontrar el factorial:");
numero=int.Parse(Console.ReadLine());

cont=numero;

for (int i = 0; i < numero; i++)
{
    if(numero !=0)
    {
    factorial*=cont;
    cont--;
}
}
Console.WriteLine($"el resultado del factorial de {numero} es = {factorial}");




        }
    }
}
