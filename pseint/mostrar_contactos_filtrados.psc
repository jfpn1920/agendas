Algoritmo mostrar_contactos_filtrados
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    Definir filtro Como Cadena
    cantidad <- 4
    Dimension contactos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    contactos[4] <- "Juana"
    Escribir "=== FILTRAR CONTACTOS ==="
    Escribir "Ingrese el nombre a buscar:"
    Leer filtro
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] = filtro Entonces
            Escribir "Contacto encontrado: ", contactos[i]
        FinSi
    FinPara
FinAlgoritmo