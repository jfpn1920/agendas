Algoritmo sistema_completo_con_menu
	Definir contactos Como Cadena
	Definir opcion, i, j, contador, n, pos, confirmar Como Entero
	Definir nombre, buscar, nuevoNombre, aux Como Cadena
	Definir encontrado Como Logico
	n <- 10
	Dimension contactos[n]
	Para i <- 0 Hasta n-1 Hacer
		contactos[i] <- ""
	FinPara
	contador <- 0
	Repetir
		Escribir "===================================="
		Escribir "        SISTEMA DE AGENDA"
		Escribir "===================================="
		Escribir "1. Agregar contacto"
		Escribir "2. Buscar contacto"
		Escribir "3. Mostrar agenda"
		Escribir "4. Eliminar contacto"
		Escribir "5. Modificar contacto"
		Escribir "6. Ordenar contactos"
		Escribir "7. Limpiar agenda"
		Escribir "8. Salir"
		Escribir "===================================="
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
					Escribir "Agenda vacía"
				SiNo
					Repetir
						Escribir "Ingrese nombre a buscar:"
						Leer buscar
					Hasta Que buscar <> ""
					encontrado <- Falso
					Para i <- 0 Hasta contador-1 Hacer
						Si contactos[i] = buscar Entonces
							encontrado <- Verdadero
						FinSi
					FinPara
					Si encontrado Entonces
						Escribir "Contacto encontrado ?"
					SiNo
						Escribir "No existe ?"
					FinSi
					
				FinSi
			3:
				Si contador = 0 Entonces
					Escribir "La agenda está vacía"
				SiNo
					Para i <- 0 Hasta contador-1 Hacer
						Escribir i+1, ". ", contactos[i]
					FinPara
				FinSi
			4:
				Si contador = 0 Entonces
					Escribir "Agenda vacía"
				SiNo
					Repetir
						Escribir "Ingrese nombre a eliminar:"
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
						Para j <- pos Hasta contador-2 Hacer
							contactos[j] <- contactos[j+1]
						FinPara
						contactos[contador-1] <- ""
						contador <- contador - 1
						Escribir "Eliminado ?"
					SiNo
						Escribir "No encontrado ?"
					FinSi
				FinSi
			5:
				Si contador = 0 Entonces
					Escribir "Agenda vacía"
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
							Escribir "Nuevo nombre:"
							Leer nuevoNombre
						Hasta Que nuevoNombre <> ""
						contactos[pos] <- nuevoNombre
						Escribir "Modificado ?"
					SiNo
						Escribir "No encontrado ?"
					FinSi
				FinSi
			6:
				Si contador = 0 Entonces
					Escribir "Agenda vacía"
				SiNo
					Para i <- 0 Hasta contador-2 Hacer
						Para j <- 0 Hasta contador-2 Hacer
							Si contactos[j] > contactos[j+1] Entonces
								aux <- contactos[j]
								contactos[j] <- contactos[j+1]
								contactos[j+1] <- aux
							FinSi
						FinPara
					FinPara
					Escribir "Ordenados ?"
				FinSi
			7:
				Si contador = 0 Entonces
					Escribir "Ya está vacía"
				SiNo
					Escribir "¿Desea limpiar todo?"
					Escribir "1. SI"
					Escribir "2. NO"
					Leer confirmar
					Si confirmar = 1 Entonces
						Para i <- 0 Hasta n-1 Hacer
							contactos[i] <- ""
						FinPara
						contador <- 0
						Escribir "Agenda limpia ?"
					SiNo
						Escribir "Cancelado"
					FinSi
				FinSi
			8:
				Escribir "Saliendo del sistema..."
			De Otro Modo:
				Escribir "Opción inválida"
		FinSegun
	Hasta Que opcion = 8
FinAlgoritmo