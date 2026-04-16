Algoritmo contar_contactos
    Definir nombre Como Cadena
    Definir contador Como Entero
    Definir continuar Como Cadena
    contador <- 0
    Escribir "=== CONTAR CONTACTOS ==="
    Repetir
        Escribir "Ingrese el nombre del contacto:"
        Leer nombre
        contador <- contador + 1
        Escribir "¿Desea agregar otro contacto? (si/no):"
        Leer continuar
    Hasta Que continuar = "no"
    Escribir "?? Total de contactos ingresados: ", contador
FinAlgoritmo