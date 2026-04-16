Algoritmo repetir_registro_hasta_salir
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    Definir nombre Como Cadena
    cantidad <- 5
    Dimension contactos[cantidad]
    i <- 1
    Escribir "=== REGISTRO DE CONTACTOS ==="
    Escribir "Escriba la palabra salir para terminar"
    Mientras i <= cantidad Hacer
        Escribir "Ingrese el nombre del contacto ", i, ":"
        Leer nombre
        Si nombre = "salir" Entonces
            i <- cantidad + 1
        SiNo
            contactos[i] <- nombre
            i <- i + 1
        FinSi
    FinMientras
    Escribir "=== CONTACTOS GUARDADOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] <> "" Entonces
            Escribir "Contacto ", i, ": ", contactos[i]
        FinSi
    FinPara
FinAlgoritmo