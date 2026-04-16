Algoritmo mostrar_agenda_en_bucle
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    cantidad <- 3
    Dimension contactos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    Escribir "=== AGENDA DE CONTACTOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Contacto ", i, ": ", contactos[i]
    FinPara
FinAlgoritmo