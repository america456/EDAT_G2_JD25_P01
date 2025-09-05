using System.ComponentModel.Design;
using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Memoria");
        //int edad = 7;
        //edad++;
        //edad++;
        //Persona pers = new Persona();
        //edad++;

  .
        //Console.WriteLine(" Expresion Lambda como funcion");
        //Func<int, int> funcionb = (a) => a * 25;
        //int resultado = funcionb(4);
        //Console.WriteLine(" El resultado es: " + resultado);

        //Console.WriteLine(" Expresion Lambda como funcion");
        //Func<int,int,int> suma= (a,b) => a + b;
        //int resultado = suma(24,28);
        //Console.WriteLine(" El resultado es: "+resultado);

        //Console.WriteLine(" Expresion Lambda como funcion");
        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b)
        //    { 
        //        return a;
        //    }
        //    else
        //    {
        //    return b;
        //    }
        //};
        //int res = mayor(4,52);
        //Console.WriteLine(" El mayor es: "+ res);

        //Console.WriteLine(" Expresion Lambda como funcion");

        //var numeros = new List<int> { 8, 25, 10, 4, 0, -5 };
        //Func<int, bool> ObtenerPares = (num) => num % 2 == 0;

        //var pares = numeros.Where(ObtenerPares);

        //Console.WriteLine(" Expresion Lambda como funcion");
        //var numeros= new List<int> {8,25,10,46,12,0,-5 };
        //Action<int> mostrar = (num) => Console.WriteLine("Posicion"+num);
        //mostrar(5);


        //Console.WriteLine(" Expresion Lambda como funcion");

        //Console.WriteLine("Ingrese un numero ");
        //string num=Console.ReadLine();
        //Func<int,int> func =>(n);
        //for (int i = 0; i < n; i++)
        //{
        //    num = n * i;
        //};




        //Ejercicios de tarea 
        // Función lambda factorial
        //Func<int, int> factorial = n =>
        //{
        //    int resultado = 1;
        //    for (int i = 1; i <= n; i++)
        //        resultado = resultado * i;
        //    return resultado;
        //};

        //Console.Write("Ingresa un número: ");
        //int numero = int.Parse(Console.ReadLine());

        //Console.WriteLine("Factorial: " + factorial(numero));

        // Función lambda para verificar si es par
        //Func<int, bool> esPar = n => n % 2 == 0;

        //Console.Write("Ingresa un número: ");
        //int numero = int.Parse(Console.ReadLine());

        //Console.WriteLine("¿Es par? " + esPar(numero));




        // Función lambda para encontrar el número menor
        //Func<int[], int> menorNumero = numeros =>
        //{
        //    int menor = numeros[0];
        //    foreach (int num in numeros)
        //        if (num < menor) menor = num;
        //    return menor;
        //};

        //int[] arreglo = { 5, 2, 8, 1, 9, 3 };
        //Console.WriteLine("El número menor es: " + menorNumero(arreglo));



        // Función lambda para multiplicar string
        //Func<string, int, string> multiplicarString = (texto, veces) =>
        //{
        //    StringBuilder resultado = new StringBuilder();
        //    for (int i = 0; i < veces; i++)
        //        resultado.Append(texto);
        //    return resultado.ToString();
        //};

        //Console.Write("Ingresa un texto: ");
        //string texto = Console.ReadLine();

        //Console.Write("Ingresa cuántas veces repetir: ");
        //int veces = int.Parse(Console.ReadLine());

        //Console.WriteLine("Resultado: " + multiplicarString(texto, veces));
        Console.ReadKey();
    }
}