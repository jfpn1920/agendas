Algoritmo registrar_contactos_con_while
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    Escribir "¿Cuántos contactos desea registrar?"
    Leer cantidad
    Dimension contactos[cantidad]
    i <- 1
    Mientras i <= cantidad Hacer
        Escribir "Ingrese el nombre del contacto ", i, ":"
        Leer contactos[i]
        i <- i + 1
    FinMientras
    Escribir "=== CONTACTOS REGISTRADOS ==="
    i <- 1
    Mientras i <= cantidad Hacer
        Escribir "Contacto ", i, ": ", contactos[i]
        i <- i + 1
    FinMientras
FinAlgoritmo