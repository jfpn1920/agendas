Algoritmo validar_correo_correcto
    Definir correo Como Cadena
    Definir valido Como Logico
    Definir i Como Entero
    Definir tieneArroba, tienePunto Como Logico
    valido <- Falso
    Mientras valido = Falso Hacer
        Escribir "Ingrese su correo:"
        Leer correo
        tieneArroba <- Falso
        tienePunto <- Falso
        Si correo = "" Entonces
            Escribir "? El correo no puede estar vacío"
        SiNo
            Para i <- 1 Hasta Longitud(correo) Hacer
                Si Subcadena(correo, i, i) = "@" Entonces
                    tieneArroba <- Verdadero
                FinSi
                Si Subcadena(correo, i, i) = "." Entonces
                    tienePunto <- Verdadero
                FinSi
            FinPara
            Si tieneArroba = Verdadero Y tienePunto = Verdadero Entonces
                valido <- Verdadero
            SiNo
                Escribir "? Correo inválido, debe contener @ y ."
            FinSi
        FinSi
    FinMientras
    Escribir "? Correo válido: ", correo
FinAlgoritmo