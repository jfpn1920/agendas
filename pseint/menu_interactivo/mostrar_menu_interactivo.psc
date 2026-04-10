Algoritmo mostrar_menu_interactivo
	Definir opcion Como Entero
	Repetir
		Escribir "=============================="
		Escribir "        MENU DE AGENDA"
		Escribir "=============================="
		Escribir "1. Agregar contacto"
		Escribir "2. Mostrar contactos"
		Escribir "3. Buscar contacto"
		Escribir "4. Eliminar contacto"
		Escribir "5. Salir"
		Escribir "=============================="
		Escribir "Seleccione una opción:"
		Leer opcion
		Segun opcion Hacer
			1:
				Escribir "Opción 1: Agregar contacto"
			2:
				Escribir "Opción 2: Mostrar contactos"
			3:
				Escribir "Opción 3: Buscar contacto"
			4:
				Escribir "Opción 4: Eliminar contacto"
			5:
				Escribir "Saliendo del sistema..."
			De Otro Modo:
				Escribir "Error: Opción inválida"
		FinSegun
	Hasta Que opcion = 5
FinAlgoritmo