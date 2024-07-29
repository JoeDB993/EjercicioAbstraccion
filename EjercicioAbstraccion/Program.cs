namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos al usuario
            Console.WriteLine("Ingrese el radio del círculo y del cilindro:");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el largo del rectángulo:");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cilindro:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el primer cateto del triángulo:");
            double catetoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo cateto del triángulo:");
            double catetoB = Convert.ToDouble(Console.ReadLine());

            // Crear instancia de OperacionesMatematicas
            OperacionesMatematicas operaciones = new OperacionesMatematicas(radio, largo, ancho, altura, catetoA, catetoB);

            // Imprimir resultados
            operaciones.Imprimir();
        }
    }
}