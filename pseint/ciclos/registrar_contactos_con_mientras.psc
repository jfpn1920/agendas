Algoritmo registrar_contactos_con_mientras
    Definir contador Como Entero
    Definir nombre, telefono Como Cadena
    contador <- 1
    Mientras contador <= 3 Hacer
        Escribir "Contacto ", contador
        Escribir "Ingrese el nombre:"
        Leer nombre
        Escribir "Ingrese el telefono:"
        Leer telefono
        Escribir "Contacto guardado correctamente"
        Escribir "---------------------------"
        contador <- contador + 1
    FinMientras
FinAlgoritmo