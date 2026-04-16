Algoritmo guardar_nombre_telefono_correo
    Definir nombres, telefonos, correos Como Cadena
    Definir i, cantidad Como Entero
    Escribir "¿Cuántos contactos desea guardar?"
    Leer cantidad
    Dimension nombres[cantidad]
    Dimension telefonos[cantidad]
    Dimension correos[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Ingrese el nombre:"
        Leer nombres[i]
        Escribir "Ingrese el teléfono:"
        Leer telefonos[i]
        Escribir "Ingrese el correo:"
        Leer correos[i]
    FinPara
    Escribir "=== CONTACTOS GUARDADOS ==="
    Para i <- 1 Hasta cantidad Hacer
        Escribir "Contacto ", i, ":"
        Escribir "Nombre: ", nombres[i]
        Escribir "Teléfono: ", telefonos[i]
        Escribir "Correo: ", correos[i]
        Escribir "----------------------"
    FinPara
FinAlgoritmo