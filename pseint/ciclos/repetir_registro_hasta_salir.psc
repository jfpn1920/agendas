Proceso repetir_registro_hasta_salir
    Definir nombre, telefono, opcion Como Cadena
    Repetir
        Escribir "Ingrese el nombre:"
        Leer nombre
        Escribir "Ingrese el telefono:"
        Leer telefono
        Escribir "Contacto guardado"
        Escribir "¿Desea registrar otro contacto? (si/no):"
        Leer opcion
    Hasta Que opcion = "no"
    Escribir "Registro finalizado"
FinProceso