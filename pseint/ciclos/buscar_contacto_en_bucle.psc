Algoritmo buscar_contacto_en_bucle
    Definir i Como Entero
    Definir nombre, buscado Como Cadena
    Definir encontrado Como Logico
    encontrado <- Falso
    Escribir "Ingrese el nombre a buscar:"
    Leer buscado
    Para i <- 1 Hasta 3 Hacer
        nombre <- "Contacto" + ConvertirATexto(i)
        Si nombre = buscado Entonces
            encontrado <- Verdadero
        FinSi
    FinPara
    Si encontrado Entonces
        Escribir "Contacto encontrado"
    SiNo
        Escribir "Contacto no encontrado"
    FinSi
FinAlgoritmo