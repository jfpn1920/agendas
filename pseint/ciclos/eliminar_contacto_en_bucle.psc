Algoritmo eliminar_contacto_en_bucle
    Definir i Como Entero
    Definir nombre, eliminar Como Cadena
    Escribir "Ingrese el nombre del contacto a eliminar:"
    Leer eliminar
    Para i <- 1 Hasta 3 Hacer
        nombre <- "Contacto" + ConvertirATexto(i)
        Si nombre = eliminar Entonces
            Escribir "Contacto ", nombre, " eliminado"
        SiNo
            Escribir "Contacto ", nombre, " se mantiene"
        FinSi
    FinPara
FinAlgoritmo