Algoritmo modificar_contacto_desde_menu
	Definir contactos Como Cadena
	Definir opcion, i, contador, n, pos Como Entero
	Definir nombre, buscar, nuevoNombre Como Cadena
	Definir encontrado Como Logico
	n <- 5
	Dimension contactos[n]
	Para i <- 0 Hasta n-1 Hacer
		contactos[i] <- ""
	FinPara
	contador <- 0
	Repetir
		Escribir "=============================="
		Escribir "        MENU DE AGENDA"
		Escribir "=============================="
		Escribir "1. Agregar contacto"
		Escribir "2. Modificar contacto"
		Escribir "3. Mostrar contactos"
		Escribir "4. Salir"
		Escribir "=============================="
		Escribir "Seleccione una opción:"
		Leer opcion
		Segun opcion Hacer
			1:
				Si contador < n Entonces
					Repetir
						Escribir "Ingrese nombre:"
						Leer nombre
					Hasta Que nombre <> ""
					contactos[contador] <- nombre
					contador <- contador + 1
					Escribir "Contacto agregado ?"
				SiNo
					Escribir "Agenda llena"
				FinSi
			2:
				Si contador = 0 Entonces
					Escribir "La agenda está vacía"
				SiNo
					Repetir
						Escribir "Ingrese nombre a modificar:"
						Leer buscar
					Hasta Que buscar <> ""
					encontrado <- Falso
					pos <- -1
					Para i <- 0 Hasta contador-1 Hacer
						Si contactos[i] = buscar Entonces
							encontrado <- Verdadero
							pos <- i
						FinSi
					FinPara
					Si encontrado Entonces
						Repetir
							Escribir "Ingrese el nuevo nombre:"
							Leer nuevoNombre
						Hasta Que nuevoNombre <> ""
						contactos[pos] <- nuevoNombre
						Escribir "Contacto modificado correctamente ?"
					SiNo
						Escribir "Contacto no encontrado ?"
					FinSi
				FinSi
			3:
				Si contador = 0 Entonces
					Escribir "Agenda vacía"
				SiNo
					Para i <- 0 Hasta contador-1 Hacer
						Escribir i+1, ". ", contactos[i]
					FinPara
				FinSi
			4:
				Escribir "Saliendo..."
			De Otro Modo:
				Escribir "Opción inválida"
		FinSegun
	Hasta Que opcion = 4
FinAlgoritmo