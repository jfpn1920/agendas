Algoritmo validar_campos_obligatorios
    Definir nombre, telefono Como Cadena
    Escribir "Ingrese el nombre:"
    Leer nombre
    Escribir "Ingrese el telefono:"
    Leer telefono
    Si nombre <> "" Y telefono <> "" Entonces
        Escribir "Todos los campos obligatorios fueron ingresados"
    SiNo
        Escribir "Faltan campos obligatorios"
    FinSi
FinAlgoritmo