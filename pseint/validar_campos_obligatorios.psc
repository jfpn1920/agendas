Algoritmo validar_campos_obligatorios
    Definir nombre, telefono, correo Como Cadena
    Definir valido Como Logico
    valido <- Falso
    Mientras valido = Falso Hacer
        Escribir "=== REGISTRO DE CONTACTO ==="
        Escribir "Ingrese nombre:"
        Leer nombre
        Escribir "Ingrese teléfono:"
        Leer telefono
        Escribir "Ingrese correo:"
        Leer correo
        Si nombre = "" O telefono = "" O correo = "" Entonces
            Escribir "? Todos los campos son obligatorios"
        SiNo
            valido <- Verdadero
        FinSi
    FinMientras
    Escribir "? Contacto registrado correctamente"
FinAlgoritmo