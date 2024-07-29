

namespace EjercicioAbstraccion
{
    public class OperacionesMatematicas : Matematicas
    {
        private double radio;
        private double largo;
        private double ancho;
        private double altura;
        private double catetoA;
        private double catetoB;

        public OperacionesMatematicas(double radio, double largo, double ancho, double altura, double catetoA, double catetoB)
        {
            this.radio = radio;
            this.largo = largo;
            this.ancho = ancho;
            this.altura = altura;
            this.catetoA = catetoA;
            this.catetoB = catetoB;
        }

        public override double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularPerimetroRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }

        public override double CalcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public override double CalcularHipotenusaTriangulo(double catetoA, double catetoB)
        {
            return Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
        }

        public override void Imprimir()
        {
            Console.WriteLine("Área del círculo: " + CalcularAreaCirculo(radio));
            Console.WriteLine("Perímetro del rectángulo: " + CalcularPerimetroRectangulo(largo, ancho));
            Console.WriteLine("Volumen del cilindro: " + CalcularVolumenCilindro(radio, altura));
            Console.WriteLine("Hipotenusa del triángulo: " + CalcularHipotenusaTriangulo(catetoA, catetoB));
        }
    }
}
