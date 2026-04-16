Algoritmo clasificar_contactos_por_tipo
    Definir nombres, tipos Como Cadena
    Definir i, cantidad Como Entero
    Escribir "¿Cuántos contactos desea registrar?"
    Leer cantidad
    Dimension nombres[cantidad]
    Dimension tipos[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Nombre del contacto:"
        Leer nombres[i]
		
        Escribir "Tipo (familia/trabajo/amigos):"
        Leer tipos[i]
    FinPara
    Escribir "=== CONTACTOS FAMILIA ==="
    Para i <- 1 Hasta cantidad Hacer
        Si tipos[i] = "familia" Entonces
            Escribir nombres[i]
        FinSi
    FinPara
    Escribir "=== CONTACTOS TRABAJO ==="
    Para i <- 1 Hasta cantidad Hacer
        Si tipos[i] = "trabajo" Entonces
            Escribir nombres[i]
        FinSi
    FinPara
    Escribir "=== CONTACTOS AMIGOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Si tipos[i] = "amigos" Entonces
            Escribir nombres[i]
        FinSi
    FinPara
FinAlgoritmo