Algoritmo mostrar_contactos_filtrados
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir i, n Como Entero
	Definir filtro Como Cadena
	Escribir "¿Cuántos contactos tienes?"
	Leer n
	Dimension nombres[n]
	Dimension telefonos[n]
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Ingrese el nombre del contacto ", i+1
		Leer nombres[i]
		Escribir "Ingrese el teléfono del contacto ", i+1
		Leer telefonos[i]
	FinPara
	Escribir "Ingrese el nombre o letra para filtrar:"
	Leer filtro
	Escribir "Contactos filtrados:"
	Para i <- 0 Hasta n-1 Hacer
		Si Subcadena(nombres[i], 0, Longitud(filtro)-1) = filtro Entonces
			Escribir "Nombre: ", nombres[i]
			Escribir "Teléfono: ", telefonos[i]
			Escribir "-------------------"
		FinSi
	FinPara
FinAlgoritmo