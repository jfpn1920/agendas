Algoritmo validar_criterios_combinados
    Definir nombre, telefono, categoria Como Cadena
    Escribir "Ingrese el nombre:"
    Leer nombre
    Escribir "Ingrese el telefono:"
    Leer telefono
    Escribir "Ingrese la categoria (familia/trabajo):"
    Leer categoria
    Si (nombre <> "" Y telefono <> "") Y (categoria = "familia" O categoria = "trabajo") Entonces
        Escribir "Criterios combinados validos"
    SiNo
        Escribir "No cumple con los criterios"
    FinSi
FinAlgoritmo