Algoritmo eliminar_contacto_en_bucle
    Definir contacto_guardado, nombre_eliminar Como Cadena
    Definir eliminado Como Logico
    contacto_guardado <- "Juan"
    eliminado <- Falso
    Escribir "=== ELIMINAR CONTACTO ==="
    Mientras eliminado = Falso Hacer
        Escribir "Ingrese el nombre del contacto a eliminar:"
        Leer nombre_eliminar
        Si nombre_eliminar = contacto_guardado Entonces
            contacto_guardado <- ""   // Simula eliminación
            Escribir "? Contacto eliminado correctamente"
            eliminado <- Verdadero
        SiNo
            Escribir "? Contacto no encontrado, intenta nuevamente"
        FinSi
    FinMientras
FinAlgoritmo