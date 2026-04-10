Algoritmo validar_datos_completos_and_correctos
    Definir nombre, telefono, correo Como Cadena
    Escribir "Ingrese el nombre:"
    Leer nombre
    Escribir "Ingrese el telefono:"
    Leer telefono
    Escribir "Ingrese el correo:"
    Leer correo
    Si nombre <> "" Y telefono <> "" Y correo <> "" Entonces
        Escribir "Datos completos y correctos"
    SiNo
        Escribir "Datos incompletos o incorrectos"
    FinSi
FinAlgoritmo