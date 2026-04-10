Algoritmo agregar_contacto_desde_menu
	Definir contactos Como Cadena
	Definir opcion, i, contador, n Como Entero
	Definir nombre Como Cadena
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
		Escribir "2. Mostrar contactos"
		Escribir "3. Salir"
		Escribir "=============================="
		Escribir "Seleccione una opción:"
		Leer opcion
		Segun opcion Hacer
			1:
				Si contador < n Entonces
					Repetir
						Escribir "Ingrese el nombre del contacto:"
						Leer nombre
						Si nombre = "" Entonces
							Escribir "Error: No puede estar vacío"
						FinSi
					Hasta Que nombre <> ""
					contactos[contador] <- nombre
					contador <- contador + 1
					Escribir "Contacto agregado correctamente ?"
				SiNo
					Escribir "Agenda llena, no se pueden agregar más contactos"
				FinSi
			2:
				Si contador = 0 Entonces
					Escribir "La agenda está vacía"
				SiNo
					Escribir "Lista de contactos:"
					Para i <- 0 Hasta contador-1 Hacer
						Escribir i+1, ". ", contactos[i]
					FinPara
				FinSi
			3:
				Escribir "Saliendo..."
			De Otro Modo:
				Escribir "Opción inválida"
		FinSegun
	Hasta Que opcion = 3
FinAlgoritmo