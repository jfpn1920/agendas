Algoritmo verificar_contacto_favorito
    Definir contactos Como Cadena
    Definir favoritos Como Logico
    Definir i, cantidad Como Entero
    Definir buscar Como Cadena
    Definir encontrado Como Logico
    cantidad <- 4	
    Dimension contactos[cantidad]
    Dimension favoritos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    contactos[4] <- "Ana"
    favoritos[1] <- Verdadero
    favoritos[2] <- Falso
    favoritos[3] <- Verdadero
    favoritos[4] <- Falso
    encontrado <- Falso
    Escribir "Ingrese el nombre del contacto:"
    Leer buscar
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] = buscar Entonces
            encontrado <- Verdadero
            Si favoritos[i] = Verdadero Entonces
                Escribir "? El contacto es favorito"
            SiNo
                Escribir "?? El contacto existe pero no es favorito"
            FinSi
        FinSi
    FinPara
    Si encontrado = Falso Entonces
        Escribir "? El contacto no existe"
    FinSi
FinAlgoritmo