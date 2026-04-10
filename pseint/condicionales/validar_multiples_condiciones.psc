Algoritmo validar_multiples_condiciones
    Definir nombre, telefono, categoria Como Cadena
    Escribir "Ingrese el nombre:"
    Leer nombre
    Escribir "Ingrese el telefono:"
    Leer telefono
    Escribir "Ingrese la categoria (familia/trabajo):"
    Leer categoria
    Si nombre <> "" Y telefono <> "" Y (categoria = "familia" O categoria = "trabajo") Entonces
        Escribir "Datos validos y categoria correcta"
    SiNo
        Escribir "Error en los datos ingresados"
    FinSi
FinAlgoritmo