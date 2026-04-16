Algoritmo mostrar_menu_interactivo
    Definir contactos Como Cadena
    Definir opcion, i, cantidad Como Entero
    Definir nombre, buscar Como Cadena
    Definir encontrado, agregado Como Logico
    cantidad <- 3
    Dimension contactos[cantidad]
    Para i <- 1 Hasta cantidad Hacer
        contactos[i] <- ""
    FinPara
    Repetir
        Escribir "===== MENÚ AGENDA ====="
        Escribir "1. Agregar contacto"
        Escribir "2. Mostrar contactos"
        Escribir "3. Buscar contacto"
        Escribir "4. Eliminar contacto"
        Escribir "5. Salir"
        Escribir "Seleccione una opción:"
        Leer opcion
        Segun opcion Hacer
            1:
                agregado <- Falso
                Para i <- 1 Hasta cantidad Hacer
                    Si contactos[i] = "" Y agregado = Falso Entonces
                        Escribir "Ingrese el nombre del contacto:"
                        Leer nombre
                        contactos[i] <- nombre
                        Escribir "? Contacto agregado"
                        agregado <- Verdadero
                    FinSi
                FinPara
                Si agregado = Falso Entonces
                    Escribir "? Agenda llena"
                FinSi
            2:
                Escribir "=== LISTA DE CONTACTOS ==="
                Para i <- 1 Hasta cantidad Hacer
                    Si contactos[i] <> "" Entonces
                        Escribir i, ": ", contactos[i]
                    FinSi
                FinPara
            3:
                Escribir "Ingrese el nombre a buscar:"
                Leer buscar
                encontrado <- Falso
                Para i <- 1 Hasta cantidad Hacer
                    Si contactos[i] = buscar Entonces
                        Escribir "? Contacto encontrado en posición ", i
                        encontrado <- Verdadero
                    FinSi
                FinPara
                Si encontrado = Falso Entonces
                    Escribir "? Contacto no encontrado"
                FinSi
            4:
                Escribir "Ingrese el nombre a eliminar:"
                Leer buscar
                encontrado <- Falso
                Para i <- 1 Hasta cantidad Hacer
                    Si contactos[i] = buscar Entonces
                        contactos[i] <- ""
                        Escribir "? Contacto eliminado"
                        encontrado <- Verdadero
                    FinSi
                FinPara
                Si encontrado = Falso Entonces
                    Escribir "? Contacto no encontrado"
                FinSi
            5:
                Escribir "?? Saliendo del sistema..."
            De Otro Modo:
                Escribir "? Opción inválida"
        FinSegun
    Hasta Que opcion = 5
FinAlgoritmo