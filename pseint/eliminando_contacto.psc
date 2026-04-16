Algoritmo eliminando_contacto
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
    Escribir "Ingrese el nombre del contacto a eliminar:"
    Leer buscar
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] = buscar Entonces
            contactos[i] <- ""
            encontrado <- Verdadero
            Escribir "? Contacto eliminado"
        FinSi
    FinPara
    Si encontrado = Falso Entonces
        Escribir "? El contacto no existe"
    FinSi
    Escribir "=== LISTA ACTUALIZADA ==="
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] <> "" Entonces
            Escribir contactos[i]
        FinSi
    FinPara
FinAlgoritmo