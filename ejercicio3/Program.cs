using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
                     /*Ejercicio 3. Métodos para hacer cálculos con figuras

● Crea un algoritmo que calcule el área de un círculo, cuadrado o triángulo,
para ello el sistema debe pedir la figura de la que se quiere calcular su
área y según lo introducido pedirá los valores necesarios para calcular el
área. Se debe crear un método por cada figura para calcular cada área,
este devolverá un número real mostrándolo en pantalla.

o Círculo: (radio^2) * PI.
o Triángulo: (base * altura) / 2.
o Cuadrado: lado * lado
*/
string figura=" ";
const double pi=3.1416;
double radio;
double bas;
double altura;
double lado;
double area=0;
int cont=0;

Console.WriteLine("a que figura deseas encontrarle el area:");

while (cont==0)
{
    Console.WriteLine($"--------------------------------------------------------------------------------");
    Console.WriteLine("--circulo"+"\n"+"--triangulo"+"\n"+"--cuadrado");
   figura=Console.ReadLine();

   if (figura !="circulo" && figura != "triangulo" && figura!="cuadrado")
   {
       Console.WriteLine("esa figura no esta entre las opciones, elige una de las tres opciones validas:");
   }  
   else
   {
       cont=1;
   }
}

Console.WriteLine($"--------------------------------------------------------------------------------");
if(figura=="circulo")
{
Console.WriteLine("Digita el radio de tu circunferencia:");
radio=double.Parse(Console.ReadLine());
 area=Math.Pow(radio,2) * pi;
}
else if(figura=="triangulo")
{
Console.WriteLine("Digita la base de tu triangulo:");
bas=double.Parse(Console.ReadLine());
Console.WriteLine("Digita la altura de tu triangulo:");
altura=double.Parse(Console.ReadLine());
area=(bas*altura)/2;  
    
}
else
{
Console.WriteLine("Digita el lado de tu cuadrado:");
lado=double.Parse(Console.ReadLine()); 
area=lado*lado; 
}
Console.WriteLine($"--------------------------------------------------------------------------------");
Console.WriteLine($"El area de tu {figura} es {area}");
   

        }
    }
}
