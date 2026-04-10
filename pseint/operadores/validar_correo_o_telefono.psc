Algoritmo validar_correo_o_telefono
    Definir correo, telefono Como Cadena
    Escribir "Ingrese el correo:"
    Leer correo
    Escribir "Ingrese el telefono:"
    Leer telefono
    Si correo <> "" O telefono <> "" Entonces
        Escribir "Al menos uno es valido"
    SiNo
        Escribir "Debe ingresar correo o telefono"
    FinSi
FinAlgoritmo