Algoritmo eliminar_contacto
	Definir nombres, telefonos, correos Como Cadena
	Definir i, j, n Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	n <- 4
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Carlos"
	nombres[4] <- "Maria"
	telefonos[1] <- "111"
	telefonos[2] <- "222"
	telefonos[3] <- "333"
	telefonos[4] <- "444"
	correos[1] <- "ana@mail.com"
	correos[2] <- "luis@mail.com"
	correos[3] <- "carlos@mail.com"
	correos[4] <- "maria@mail.com"
	encontrado <- Falso
	Escribir "Ingrese el nombre del contacto a eliminar:"
	Leer buscar
	Para i <- 1 Hasta n Hacer
		Si nombres[i] = buscar Entonces
			Para j <- i Hasta n-1 Hacer
				
				nombres[j] <- nombres[j+1]
				telefonos[j] <- telefonos[j+1]
				correos[j] <- correos[j+1]
			FinPara
			n <- n - 1
			encontrado <- Verdadero
			Escribir "Contacto eliminado correctamente"
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	FinSi
FinAlgoritmo