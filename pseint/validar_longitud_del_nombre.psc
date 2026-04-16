Algoritmo validar_longitud_del_nombre
    Definir nombre Como Cadena
    Definir valido Como Logico
    Definir c1, c2, c3 Como Cadena
    valido <- Falso
    Mientras valido = Falso Hacer
        Escribir "Ingrese su nombre:"
        Leer nombre
        Si nombre = "" Entonces
            Escribir "? El nombre no puede estar vacío"
        SiNo
            c1 <- Subcadena(nombre,1,1)
            c2 <- Subcadena(nombre,2,2)
            c3 <- Subcadena(nombre,3,3)
            Si c1 = "" O c2 = "" O c3 = "" Entonces
                Escribir "? El nombre debe tener mínimo 3 caracteres"
            SiNo
                valido <- Verdadero
            FinSi
        FinSi
    FinMientras
    Escribir "? Nombre válido: ", nombre
FinAlgoritmo