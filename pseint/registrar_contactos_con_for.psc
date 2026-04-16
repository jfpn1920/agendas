Algoritmo registrar_contactos_con_for
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    Escribir "¿Cuántos contactos desea registrar?"
    Leer cantidad
    Dimension contactos[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Ingrese el nombre del contacto ", i, ":"
        Leer contactos[i]
    FinPara
    Escribir "=== CONTACTOS REGISTRADOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Contacto ", i, ": ", contactos[i]
    FinPara
FinAlgoritmo