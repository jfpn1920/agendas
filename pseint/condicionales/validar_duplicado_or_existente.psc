Algoritmo validar_duplicado_or_existente
    Definir nombre_ingresado, contacto_guardado Como Cadena
    contacto_guardado <- "Juan Perez"
    Escribir "Ingrese el nombre del contacto:"
    Leer nombre_ingresado
    Si nombre_ingresado = contacto_guardado O nombre_ingresado = "Maria Lopez" Entonces
        Escribir "El contacto es duplicado o ya existe"
    SiNo
        Escribir "El contacto no existe"
    FinSi
FinAlgoritmo