// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = System.Math.Round(float(a/b),5);

[<EntryPoint>]
let main argv = 
    Console.Write("Introduzca el 1er numero: ")
    let num1 = Convert.ToDouble(Console.ReadLine())
    Console.Write("Introduzca el 2do numero: ")
    let num2 = Convert.ToDouble(Console.ReadLine())
    Console.WriteLine()
    Console.WriteLine("Resultado de las operaciones:")
    Console.WriteLine("Suma: "+num1.ToString()+" + "+num2.ToString()+" = "+(suma num1 num2).ToString())
    Console.WriteLine("Resta: "+num1.ToString()+" - "+num2.ToString()+" = "+ (resta num1 num2).ToString())
    Console.WriteLine("Multiplicacion: "+num1.ToString()+" * "+num2.ToString()+" = "+(multiplicacion num1 num2).ToString())
    if (num2 = 0.0) then 
            Console.WriteLine("No existe division entre cero")
        else 
            Console.WriteLine("Division: "+num1.ToString()+" / "+num2.ToString()+" = "+(division num1 num2).ToString())
    let f = Console.ReadKey()
    0 