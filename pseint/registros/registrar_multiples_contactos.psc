Algoritmo registrar_multiples_contactos
	Definir nombres, telefonos, correos Como Cadena
	Definir i, n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	Escribir "Cuantos contactos desea registrar?"
	Leer n
	Para i <- 0 Hasta n-1 Hacer
		Escribir "===== CONTACTO ", i+1, " ====="
		Escribir "Ingrese el nombre:"
		Leer nombres[i]
		Escribir "Ingrese el telefono:"
		Leer telefonos[i]
		Escribir "Ingrese el correo:"
		Leer correos[i]
	FinPara
	Escribir "===== LISTA DE CONTACTOS ====="
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Contacto ", i+1
		Escribir "Nombre: ", nombres[i]
		Escribir "Telefono: ", telefonos[i]
		Escribir "Correo: ", correos[i]
		Escribir "---------------------"
	FinPara
FinAlgoritmo