Proceso contar_contactos
    Definir contador Como Entero
    Definir opcion Como Cadena
    contador <- 0
    Repetir
        Escribir "Registrando contacto..."
        contador <- contador + 1
        Escribir "¿Desea agregar otro contacto? (si/no):"
        Leer opcion
    Hasta Que opcion = "no"
    Escribir "Cantidad total de contactos: ", contador
FinProceso