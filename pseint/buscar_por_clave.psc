Algoritmo buscar_por_clave
    Definir contactos Como Cadena
    Definir clave, cantidad Como Entero
    cantidad <- 4
    Dimension contactos[cantidad]
    contactos[1] <- "Juan"
    contactos[2] <- "Maria"
    contactos[3] <- "Carlos"
    contactos[4] <- "Ana"
    Escribir "Ingrese la clave del contacto (1 a ", cantidad, "):"
    Leer clave
    Si clave >= 1 Y clave <= cantidad Entonces
        Escribir "? Contacto encontrado: ", contactos[clave]
    SiNo
        Escribir "? Clave inválida"
    FinSi
FinAlgoritmo