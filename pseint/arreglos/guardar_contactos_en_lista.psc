Algoritmo guardar_contactos_en_lista
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir i, n Como Entero
	Escribir "¿Cuántos contactos desea guardar?"
	Leer n
	Dimension nombres[n]
	Dimension telefonos[n]
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Ingrese el nombre del contacto ", i+1
		Leer nombres[i]
		Escribir "Ingrese el teléfono del contacto ", i+1
		Leer telefonos[i]
	FinPara
	Escribir "Contactos guardados correctamente"
FinAlgoritmo