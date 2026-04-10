Algoritmo recorrer_lista_de_contactos
    Definir i Como Entero
    Definir nombre, telefono Como Cadena
    Para i <- 1 Hasta 3 Hacer
        nombre <- "Contacto" + ConvertirATexto(i)
        telefono <- "300000" + ConvertirATexto(i)
        Escribir "Contacto ", i
        Escribir "Nombre: ", nombre
        Escribir "Telefono: ", telefono
        Escribir "---------------------"
    FinPara
FinAlgoritmo