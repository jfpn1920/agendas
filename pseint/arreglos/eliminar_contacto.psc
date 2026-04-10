Algoritmo eliminar_contacto
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir i, j, n Como Entero
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
	Escribir "Ingrese el nombre del contacto a eliminar:"
	Leer buscar
	Para i <- 0 Hasta n-1 Hacer
		Si encontrado = Falso Entonces
			Si nombres[i] = buscar Entonces
				Para j <- i Hasta n-2 Hacer
					nombres[j] <- nombres[j+1]
					telefonos[j] <- telefonos[j+1]
				FinPara
				n <- n - 1
				encontrado <- Verdadero
				Escribir "Contacto eliminado correctamente"
			FinSi
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	FinSi
FinAlgoritmo