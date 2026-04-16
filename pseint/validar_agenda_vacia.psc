Algoritmo validar_agenda_vacia
    Definir contactos Como Cadena
    Definir i, cantidad Como Entero
    Definir hayContactos Como Logico
    cantidad <- 5
    Dimension contactos[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        contactos[i] <- ""
    FinPara
    hayContactos <- Falso
    Para i <- 1 Hasta cantidad Hacer
        Si contactos[i] <> "" Entonces
            hayContactos <- Verdadero
        FinSi
    FinPara
    Si hayContactos = Falso Entonces
        Escribir "? La agenda está vacía"
    SiNo
        Escribir "=== CONTACTOS ==="
        Para i <- 1 Hasta cantidad Hacer
            Si contactos[i] <> "" Entonces
                Escribir contactos[i]
            FinSi
        FinPara
    FinSi
FinAlgoritmo