Algoritmo manejar_contactos_por_categorias
    Definir nombres, telefonos, correos, categorias Como Cadena
    Definir i, cantidad Como Entero
    Escribir "¿Cuántos contactos desea registrar?"
    Leer cantidad
    Dimension nombres[cantidad]
    Dimension telefonos[cantidad]
    Dimension correos[cantidad]
    Dimension categorias[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Nombre:"
        Leer nombres[i]
        Escribir "Teléfono:"
        Leer telefonos[i]
        Escribir "Correo:"
        Leer correos[i]
        Escribir "Categoría (familia/trabajo/amigos):"
        Leer categorias[i]
    FinPara
    Escribir "=== TODOS LOS CONTACTOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Escribir nombres[i], " - ", telefonos[i], " - ", correos[i], " - ", categorias[i]
    FinPara
    Escribir "=== FAMILIA ==="
    Para i <- 1 Hasta cantidad Hacer
        Si categorias[i] = "familia" Entonces
            Escribir nombres[i], " - ", telefonos[i]
        FinSi
    FinPara
    Escribir "=== TRABAJO ==="
    Para i <- 1 Hasta cantidad Hacer
        Si categorias[i] = "trabajo" Entonces
            Escribir nombres[i], " - ", telefonos[i]
        FinSi
    FinPara
    Escribir "=== AMIGOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Si categorias[i] = "amigos" Entonces
            Escribir nombres[i], " - ", telefonos[i]
        FinSi
    FinPara
FinAlgoritmo