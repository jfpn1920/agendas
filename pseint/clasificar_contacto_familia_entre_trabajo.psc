Algoritmo clasificar_contacto_familia_entre_trabajo
    Definir familia, trabajo Como Cadena
    Definir i, cantidad Como Entero
    Definir nombre, tipo Como Cadena
    Definir contFam, contTrab Como Entero
    cantidad <- 5
    Dimension familia[cantidad]
    Dimension trabajo[cantidad]
    contFam <- 0
    contTrab <- 0
    Escribir "=== CLASIFICAR CONTACTOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Ingrese el nombre del contacto:"
        Leer nombre
        Escribir "Ingrese el tipo (familia/trabajo):"
        Leer tipo
        Si tipo = "familia" Entonces
            contFam <- contFam + 1
            familia[contFam] <- nombre
        SiNo
            Si tipo = "trabajo" Entonces
                contTrab <- contTrab + 1
                trabajo[contTrab] <- nombre
            SiNo
                Escribir "? Tipo inválido"
                i <- i - 1
            FinSi
        FinSi
    FinPara
    Escribir "=== CONTACTOS FAMILIA ==="
    Para i <- 1 Hasta contFam Hacer
        Escribir familia[i]
    FinPara
    Escribir "=== CONTACTOS TRABAJO ==="
    Para i <- 1 Hasta contTrab Hacer
        Escribir trabajo[i]
    FinPara
FinAlgoritmo