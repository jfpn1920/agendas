Algoritmo actualizar_contacto
	Definir nombres Como Cadena
	Definir i, n, pos Como Entero
	Definir buscar, nuevoNombre Como Cadena
	Definir encontrado Como Logico
	n <- 3
	Dimension nombres[n]
	Para i <- 0 Hasta n-1 Hacer
		Repetir
			Escribir "Ingrese nombre del contacto ", i+1, ":"
			Leer nombres[i]
		Hasta Que nombres[i] <> ""
	FinPara
	Escribir "------------------------------"
	Escribir "Ingrese el nombre a actualizar:"
	Leer buscar
	encontrado <- Falso
	pos <- -1
	Para i <- 0 Hasta n-1 Hacer
		Si nombres[i] = buscar Entonces
			encontrado <- Verdadero
			pos <- i
		FinSi
	FinPara
	Si encontrado Entonces
		Escribir "Ingrese el nuevo nombre:"
		Repetir
			Leer nuevoNombre
		Hasta Que nuevoNombre <> ""
		nombres[pos] <- nuevoNombre
		Escribir "Contacto actualizado ?"
	SiNo
		Escribir "Contacto no encontrado ?"
	FinSi
	Escribir "------------------------------"
	Escribir "Lista actualizada:"
	Para i <- 0 Hasta n-1 Hacer
		Escribir i+1, ". ", nombres[i]
	FinPara
FinAlgoritmo