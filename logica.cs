using System;

// Clase base abstracta para formas geométricas con método abstracto para calcular el área.
public abstract class FormaGeometrica
{
    protected double parametro1;
    protected double parametro2;

    public FormaGeometrica(double parametro1, double parametro2)
    {
        this.parametro1 = parametro1;
        this.parametro2 = parametro2;
    }

    public abstract string CalcularArea();
}

// Clase derivada 1
public class Cuadrado : FormaGeometrica
{
    public Cuadrado(double parametro1, double parametro2) : base(parametro1, parametro2)
    {
    }

    public override string CalcularArea()
    {
        if (parametro1 != parametro2)
        {
            return "La figura no es un cuadrado ya que sus lados son distintos";
        }
        else
        {
            double areaCuadrado = parametro1 * parametro2;
            return $"El área del Cuadrado es {areaCuadrado}";
        }
    }
}

// Otra clase derivada 2
public class Rectangulo : FormaGeometrica
{
    public Rectangulo(double parametro1, double parametro2) : base(parametro1, parametro2)
    {
    }

    public override string CalcularArea()
    {
        if (parametro1 == parametro2)
        {
            return "La figura es un cuadrado ya que sus lados son iguales";
        }
        else
        {
            double areaRectangulo = parametro1 * parametro2;
            return $"El área del Rectángulo es {areaRectangulo}";
        }
    }
}

// Otra clase derivada 3
public class Triangulo : FormaGeometrica
{
    public Triangulo(double parametro1, double parametro2) : base(parametro1, parametro2)
    {
    }

    public override string CalcularArea()
    {
        double areaTriangulo = (parametro1 * parametro2) / 2;
        return $"El área del Triángulo es {areaTriangulo}";
    }
}

public class Circulo : FormaGeometrica
{
    public Circulo(double parametro1, double parametro2) : base(parametro1, parametro2)
    {
    }

    public override string CalcularArea()
    {
        parametro1 = Math.PI;
        parametro2 = Math.Pow(parametro2, 2);
        double areaCirculo = parametro1 * parametro2;
        return $"El área del Círculo es {areaCirculo}";
    }
}
