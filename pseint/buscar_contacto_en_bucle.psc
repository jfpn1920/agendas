Algoritmo buscar_contacto_en_bucle
    Definir contacto_guardado, nombre_buscar Como Cadena
    Definir encontrado Como Logico
    contacto_guardado <- "Juan"
    encontrado <- Falso
    Escribir "=== BUSCAR CONTACTO ==="
    Mientras encontrado = Falso Hacer
        Escribir "Ingrese el nombre del contacto:"
        Leer nombre_buscar
        Si nombre_buscar = contacto_guardado Entonces
            Escribir "? Contacto encontrado"
            encontrado <- Verdadero
        SiNo
            Escribir "? Contacto no encontrado, intenta nuevamente"
        FinSi
    FinMientras
FinAlgoritmo