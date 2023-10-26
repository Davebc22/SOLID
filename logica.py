"""
En este módulo se puede evidenciar los principios:
1. Single Responsability: Cada clase tiene una única responsabilidad en el cálculo de un área
2. Open-End: Puede ser extendida para calcular el área de nuevas formas geométricas sin modificar su código.
3. Liskov principle: Todas las clases derivadas son removibles y sustituibles

"""

# Clase base abstracta para formas geométricas con método abstracto para calcular el área.
from abc import ABC, abstractmethod
import math
# Clase abstracta
class Forma_Geometrica(ABC):
    # Método abstracto
    def __init__(self, parametro1, parametro2):
        self.parametro1 = parametro1
        self.parametro2 = parametro2

    @abstractmethod
    def calcular_area(self):
        pass

# Clase derivada 1
class Cuadrado(Forma_Geometrica):
    def calcular_area(self):
        if self.parametro1 != self.parametro2:
            return f'La figura no es un cuadrado ya que sus lados son distintos'
        else:
            area_cuadrado = self.parametro1 * self.parametro2
            return  f'El área del Cuadrado es {area_cuadrado}'


# Otra clase derivada 2
class Rectangulo(Forma_Geometrica):
    def calcular_area(self):
        if self.parametro1 == self.parametro2:
            return f'La figura es un cuadrado ya que sus lados son iguales'
        else:
            area_rectangulo = self.parametro1 * self.parametro2
            return  f'El área del Rectángulo es {area_rectangulo}'

# Otra clase derivada 3
class Triangulo(Forma_Geometrica):
    def calcular_area(self):
        area_triangulo = (self.parametro1 * self.parametro2)/2
        return  f'El área del Triángulo es {area_triangulo}'

class Circulo(Forma_Geometrica):
    def calcular_area(self):
        self.parametro1 = math.pi
        self.parametro2 = math.pow(self.parametro2, 2)
        area_circulo = (self.parametro1 * self.parametro2)
        return  f'El área del Círculo es {area_circulo}'

