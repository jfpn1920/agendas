Algoritmo mostrar_agenda_estructurada
    Definir nombres, telefonos, correos, categorias Como Cadena
    Definir i, cantidad Como Entero
    cantidad <- 3
    Dimension nombres[cantidad]
    Dimension telefonos[cantidad]
    Dimension correos[cantidad]
    Dimension categorias[cantidad]
    nombres[1] <- "Juan"
    telefonos[1] <- "123456"
    correos[1] <- "juan@gmail.com"
    categorias[1] <- "familia"
    nombres[2] <- "Maria"
    telefonos[2] <- "789456"
    correos[2] <- "maria@gmail.com"
    categorias[2] <- "trabajo"
    nombres[3] <- "Carlos"
    telefonos[3] <- "456123"
    correos[3] <- "carlos@gmail.com"
    categorias[3] <- "amigos"
    Escribir "===== AGENDA DE CONTACTOS ====="
    Para i <- 1 Hasta cantidad Hacer
        Escribir "------------------------------"
        Escribir "Contacto ", i
        Escribir "Nombre: ", nombres[i]
        Escribir "Teléfono: ", telefonos[i]
        Escribir "Correo: ", correos[i]
        Escribir "Categoría: ", categorias[i]
    FinPara
    Escribir "------------------------------"
FinAlgoritmo