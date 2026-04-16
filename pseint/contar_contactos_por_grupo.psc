Algoritmo contar_contactos_por_grupo
    Definir nombres, tipos Como Cadena
    Definir i, cantidad Como Entero
    Definir contFam, contTrab, contAmig Como Entero
    Escribir "¿Cuántos contactos desea registrar?"
    Leer cantidad
    Dimension nombres[cantidad]
    Dimension tipos[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Ingrese el nombre del contacto:"
        Leer nombres[i]
        Escribir "Ingrese el tipo (familia/trabajo/amigos):"
        Leer tipos[i]
    FinPara
    contFam <- 0
    contTrab <- 0
    contAmig <- 0
    Para i <- 1 Hasta cantidad Hacer
        Si tipos[i] = "familia" Entonces
            contFam <- contFam + 1
        SiNo
            Si tipos[i] = "trabajo" Entonces
                contTrab <- contTrab + 1
            SiNo
                Si tipos[i] = "amigos" Entonces
                    contAmig <- contAmig + 1
                FinSi
            FinSi
        FinSi
    FinPara
    Escribir "=== RESULTADOS ==="
    Escribir "Familia: ", contFam
    Escribir "Trabajo: ", contTrab
    Escribir "Amigos: ", contAmig
FinAlgoritmo