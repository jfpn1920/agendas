Algoritmo validar_si_contacto_existe
    Definir nombre Como Cadena
    Definir contacto_guardado Como Cadena
    contacto_guardado <- "Juan Perez"
    Escribir "Ingrese el nombre del contacto:"
    Leer nombre
    Si nombre = contacto_guardado Entonces
        Escribir "El contacto SI existe"
    SiNo
        Escribir "El contacto NO existe"
    FinSi
FinAlgoritmo