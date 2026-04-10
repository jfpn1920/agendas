Algoritmo validar_contacto_favorito_and_existente
    Definir nombre_ingresado, favorito Como Cadena
    favorito <- "Juan Perez"
    Escribir "Ingrese el nombre del contacto:"
    Leer nombre_ingresado
    Si nombre_ingresado = favorito Y nombre_ingresado <> "" Entonces
        Escribir "El contacto es favorito y existe"
    SiNo
        Escribir "El contacto no cumple las condiciones"
    FinSi
FinAlgoritmo