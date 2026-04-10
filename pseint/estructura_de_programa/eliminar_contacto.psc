Algoritmo eliminar_contacto
	Definir nombres Como Cadena
	Definir i, j, n, contador, pos Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	n <- 5
	Dimension nombres[n]
	contador <- 0
	Para i <- 0 Hasta n-1 Hacer
		Repetir
			Escribir "Ingrese nombre del contacto ", i+1, ":"
			Leer nombres[i]
		Hasta Que nombres[i] <> ""
		contador <- contador + 1
	FinPara
	Escribir "------------------------------"
	Escribir "Ingrese el nombre a eliminar:"
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
		Escribir "Contacto eliminado ?"
	SiNo
		Escribir "Contacto no encontrado ?"
	FinSi
	Escribir "------------------------------"
	Escribir "Lista actualizada:"
	Si contador = 0 Entonces
		Escribir "La agenda está vacía"
	SiNo
		Para i <- 0 Hasta contador-1 Hacer
			Escribir i+1, ". ", nombres[i]
		FinPara
	FinSi
FinAlgoritmo