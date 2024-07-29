namespace EjercicioAbstraccion
{
    public abstract class Matematicas
    {
        // Métodos abstractos
        public abstract double CalcularAreaCirculo(double radio);
        public abstract double CalcularPerimetroRectangulo(double largo, double ancho);
        public abstract double CalcularVolumenCilindro(double radio, double altura);
        public abstract double CalcularHipotenusaTriangulo(double catetoA, double catetoB);

        // Método para imprimir resultados
        public abstract void Imprimir();
    }
}