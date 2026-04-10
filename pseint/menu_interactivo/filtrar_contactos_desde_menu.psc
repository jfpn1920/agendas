Algoritmo filtrar_contactos_desde_menu
	Definir contactos Como Cadena
	Definir opcion, i, j, contador, n Como Entero
	Definir nombre, filtro, sub Como Cadena
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
		Escribir "2. Filtrar contactos"
		Escribir "3. Mostrar agenda"
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
						Escribir "Ingrese texto a filtrar:"
						Leer filtro
					Hasta Que filtro <> ""
					Escribir "Resultados del filtro:"
					encontrado <- Falso
					Para i <- 0 Hasta contador-1 Hacer
						Para j <- 0 Hasta 20 Hacer
							sub <- Subcadena(contactos[i], j, j)
							Si sub = Subcadena(filtro, 0, 0) Entonces
								Escribir "- ", contactos[i]
								encontrado <- Verdadero
							FinSi
						FinPara
					FinPara
					Si encontrado = Falso Entonces
						Escribir "No hay coincidencias ?"
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