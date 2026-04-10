Algoritmo mostrar_agenda_en_bucle
    Definir i Como Entero
    Definir nombre, telefono Como Cadena
    Para i <- 1 Hasta 3 Hacer
        Escribir "Contacto ", i
        nombre <- "Contacto" + ConvertirATexto(i)
        telefono <- "12345" + ConvertirATexto(i)
        Escribir "Nombre: ", nombre
        Escribir "Telefono: ", telefono
        Escribir "---------------------"
    FinPara
FinAlgoritmo