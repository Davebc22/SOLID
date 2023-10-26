"""
En este módulo se puede evidenciar el principio:
5. Dependency Inversion: clase que realiza la entrada y salida de datos en lugar de que las clases las instancien directamente
"""
import logica

def entrada_datos():
    eleccion = input('Ingrese el número correspondiente a la figura: ')
    eleccion = int(eleccion)
    return eleccion

def salida_datos():
    while True:
        print('\nBienvenidos a la calculadora de áreas, por favor elija el tipo de figura a la que le vamos a calcular el área:')
        print('1. Cuadrado \n2. Rectángulo \n3. Triángulo \n4. Círculo \n5. Salir del programa \n')
        eleccion = entrada_datos()

        if eleccion == 5:
            break  # Salir del bucle si se elige 5

        parametro1 = float(input('Ingrese el valor del primer parámetro: '))
        parametro2 = float(input('Ingrese el valor del segundo parámetro: '))

        if eleccion == 1:
            cuadrado = logica.Cuadrado(parametro1, parametro2)
            resultado = cuadrado.calcular_area()
            print(resultado)
        elif eleccion == 2:
            rectangulo = logica.Rectangulo(parametro1, parametro2)
            resultado = rectangulo.calcular_area()
            print(resultado)
        elif eleccion == 3:
            triangulo = logica.Triangulo(parametro1, parametro2)
            resultado = triangulo.calcular_area()
            print(resultado)
        elif eleccion == 4:
            circulo = logica.Circulo(parametro1, parametro2)
            resultado = circulo.calcular_area()
            print(resultado)

    print('Hasta pronto')

salida_datos()
