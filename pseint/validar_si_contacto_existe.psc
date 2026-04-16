Algoritmo validar_si_contacto_existe
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    Definir buscar Como Cadena
    Definir encontrado Como Logico
    cantidad <- 4
    Dimension contactos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    contactos[4] <- "Ana"
    encontrado <- Falso
    Escribir "Ingrese el nombre del contacto a buscar:"
    Leer buscar
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] = buscar Entonces
            encontrado <- Verdadero
        FinSi
    FinPara
    Si encontrado = Verdadero Entonces
        Escribir "? El contacto existe"
    SiNo
        Escribir "? El contacto no existe"
    FinSi
FinAlgoritmo