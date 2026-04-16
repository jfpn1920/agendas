Algoritmo verificar_duplicados
    Definir contactos Como Cadena
    Definir i, j, cantidad Como Entero
    Definir hayDuplicados Como Logico
    cantidad <- 5
    Dimension contactos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    contactos[4] <- "Juan"
    contactos[5] <- "Ana"
    hayDuplicados <- Falso
    Para i <- 1 Hasta cantidad - 1 Hacer
        Para j <- i + 1 Hasta cantidad Hacer
            Si contactos[i] = contactos[j] Entonces
                Escribir "?? Contacto duplicado: ", contactos[i]
                hayDuplicados <- Verdadero
            FinSi
        FinPara
    FinPara
    Si hayDuplicados = Falso Entonces
        Escribir "? No hay contactos duplicados"
    FinSi
FinAlgoritmo