Algoritmo recorrer_lista_de_contactos
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    cantidad <- 4
    Dimension contactos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    contactos[4] <- "Ana"
    Escribir "=== RECORRER CONTACTOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Contacto ", i, ": ", contactos[i]
    FinPara
FinAlgoritmo