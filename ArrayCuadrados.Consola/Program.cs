using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado[] arrayCuadrados=new Cuadrado[5];
            for(int i = 0; i < arrayCuadrados.Length; i++)
            {
                do
                {
                    Console.Write($"Ingrese la medida del {i + 1}° cuadrado:");
                    var lado = int.Parse(Console.ReadLine());
                    Cuadrado cuadradoCreado = new Cuadrado(lado);
                    if (cuadradoCreado.Validar())
                    {
                        arrayCuadrados[i] = cuadradoCreado;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cuadrado no valido");
                    }
                   

                } while (true);
               

            }
            Console.WriteLine("Array Lleno!!!");
            Console.Clear();
            foreach (var item in arrayCuadrados)
            {
                Console.WriteLine($"Cuadrado de lado {item.GetLado()} - Sup:{item.GetSuperficie()} - Per:{item.GetPerimetro()}");
            }

            Console.Write("Ingrese el nro de cuadrado a modificar:");
            var index=int.Parse(Console.ReadLine());
            var cuadradoEditar=arrayCuadrados[index];
            Console.Write("Ingrese nueva medida:");
            var nuevaMedida=int.Parse(Console.ReadLine());  
            cuadradoEditar.SetLado(nuevaMedida);
            Console.Clear();
            foreach (var item in arrayCuadrados)
            {
                Console.WriteLine($"Cuadrado de lado {item.GetLado()} - Sup:{item.GetSuperficie()} - Per:{item.GetPerimetro()}");
            }
        }
    }
}