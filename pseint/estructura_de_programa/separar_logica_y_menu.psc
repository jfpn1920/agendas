Algoritmo separar_logica_y_menu
	Definir opcion, contador Como Entero
	Definir contactos Como Cadena
	Dimension contactos[5]
	contador <- 0
	Repetir
		Escribir "======================"
		Escribir "   MENU DE AGENDA"
		Escribir "======================"
		Escribir "1. Agregar contacto"
		Escribir "2. Mostrar contactos"
		Escribir "3. Salir"
		Escribir "Seleccione una opción:"
		Leer opcion
		Segun opcion Hacer
			1:
				AgregarContacto(contactos, contador)
			2:
				MostrarContactos(contactos, contador)
			3:
				Escribir "Saliendo..."
			De Otro Modo:
				Escribir "Opción inválida"
		FinSegun
	Hasta Que opcion = 3
FinAlgoritmo
SubProceso AgregarContacto(contactos Por Referencia, contador Por Referencia)
	Definir nombre Como Cadena
	Si contador < 5 Entonces
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
FinSubProceso
SubProceso MostrarContactos(contactos, contador)
	Definir i Como Entero
	Si contador = 0 Entonces
		Escribir "La agenda está vacía"
	SiNo
		Para i <- 0 Hasta contador-1 Hacer
			Escribir i+1, ". ", contactos[i]
		FinPara
	FinSi
FinSubProceso