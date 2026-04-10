Algoritmo buscar_contacto
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir i, n Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	Dimension nombres[100]
	Dimension telefonos[100]
	n <- 3
	nombres[0] <- "Ana"
	nombres[1] <- "Luis"
	nombres[2] <- "Carlos"
	telefonos[0] <- "111"
	telefonos[1] <- "222"
	telefonos[2] <- "333"
	encontrado <- Falso
	Escribir "Ingrese el nombre del contacto a buscar:"
	Leer buscar
	Para i <- 0 Hasta n-1 Hacer
		Si encontrado = Falso Entonces
			Si nombres[i] = buscar Entonces
				Escribir "Contacto encontrado:"
				Escribir "Nombre: ", nombres[i]
				Escribir "Teléfono: ", telefonos[i]
				encontrado <- Verdadero
			FinSi
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	FinSi
FinAlgoritmo