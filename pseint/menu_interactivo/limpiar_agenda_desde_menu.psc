Algoritmo limpiar_agenda_desde_menu
	Definir contactos Como Cadena
	Definir opcion, i, contador, n, confirmar Como Entero
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
		Escribir "2. Mostrar agenda"
		Escribir "3. Limpiar agenda"
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
					Para i <- 0 Hasta contador-1 Hacer
						Escribir i+1, ". ", contactos[i]
					FinPara
				FinSi
			3:
				Si contador = 0 Entonces
					Escribir "La agenda ya está vacía"
				SiNo
					Escribir "¿Está seguro que desea eliminar todos los contactos?"
					Escribir "1. SI"
					Escribir "2. NO"
					Leer confirmar
					Si confirmar = 1 Entonces
						Para i <- 0 Hasta n-1 Hacer
							contactos[i] <- ""
						FinPara
						contador <- 0
						Escribir "Agenda limpiada correctamente ?"
					SiNo
						Escribir "Operación cancelada"
					FinSi
				FinSi
			4:
				Escribir "Saliendo..."
			De Otro Modo:
				Escribir "Opción inválida"
		FinSegun
	Hasta Que opcion = 4
FinAlgoritmo