Algoritmo validar_contacto_activo_and_valido
    Definir nombre, estado Como Cadena
    Escribir "Ingrese el nombre del contacto:"
    Leer nombre
    Escribir "Ingrese el estado (activo/inactivo):"
    Leer estado
    Si nombre <> "" Y estado = "activo" Entonces
        Escribir "El contacto es activo y valido"
    SiNo
        Escribir "El contacto no cumple las condiciones"
    FinSi
FinAlgoritmo