Algoritmo mini_sistema_completo_de_agenda
	Definir nombres Como Cadena
	Definir opcion, i, j, contador, n, pos Como Entero
	Definir nombre, buscar Como Cadena
	Definir encontrado Como Logico
	n <- 5
	Dimension nombres[n]
	contador <- 0
	Repetir
		Escribir "=============================="
		Escribir "     MINI AGENDA"
		Escribir "=============================="
		Escribir "1. Agregar contacto"
		Escribir "2. Buscar contacto"
		Escribir "3. Mostrar agenda"
		Escribir "4. Eliminar contacto"
		Escribir "5. Salir"
		Escribir "Seleccione una opción:"
		Leer opcion
		Segun opcion Hacer
			1:
				Si contador < n Entonces
					Repetir
						Escribir "Ingrese nombre:"
						Leer nombre
					Hasta Que nombre <> ""
					nombres[contador] <- nombre
					contador <- contador + 1
					Escribir "Contacto agregado ?"
				SiNo
					Escribir "Agenda llena"
				FinSi
			2:
				Si contador = 0 Entonces
					Escribir "Agenda vacía"
				SiNo
					Escribir "Ingrese nombre a buscar:"
					Leer buscar
					encontrado <- Falso
					Para i <- 0 Hasta contador-1 Hacer
						Si nombres[i] = buscar Entonces
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
						Escribir i+1, ". ", nombres[i]
					FinPara
				FinSi
			4:
				Si contador = 0 Entonces
					Escribir "Agenda vacía"
				SiNo
					Escribir "Ingrese nombre a eliminar:"
					Leer buscar
					encontrado <- Falso
					pos <- -1
					Para i <- 0 Hasta contador-1 Hacer
						Si nombres[i] = buscar Entonces
							encontrado <- Verdadero
							pos <- i
						FinSi
					FinPara
					Si encontrado Entonces
						Para j <- pos Hasta contador-2 Hacer
							nombres[j] <- nombres[j+1]
						FinPara
						nombres[contador-1] <- ""
						contador <- contador - 1
						Escribir "Eliminado ?"
					SiNo
						Escribir "No encontrado ?"
					FinSi
				FinSi
			5:
				Escribir "Saliendo del sistema..."
			De Otro Modo:
				Escribir "Opción inválida"
		FinSegun
	Hasta Que opcion = 5
FinAlgoritmo