Algoritmo ordenar_contactos
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir i, j, n Como Entero
	Definir aux Como Cadena
	Dimension nombres[100]
	Dimension telefonos[100]
	n <- 5
	nombres[0] <- "Carlos"
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Pedro"
	nombres[4] <- "Maria"
	telefonos[0] <- "333"
	telefonos[1] <- "111"
	telefonos[2] <- "222"
	telefonos[3] <- "444"
	telefonos[4] <- "555"
	Para i <- 0 Hasta n-2 Hacer
		Para j <- 0 Hasta n-2 Hacer
			Si nombres[j] > nombres[j+1] Entonces
				aux <- nombres[j]
				nombres[j] <- nombres[j+1]
				nombres[j+1] <- aux
				aux <- telefonos[j]
				telefonos[j] <- telefonos[j+1]
				telefonos[j+1] <- aux
			FinSi
		FinPara
	FinPara
	Escribir "Contactos ordenados:"
	Para i <- 0 Hasta n-1 Hacer
		Escribir nombres[i], " - ", telefonos[i]
	FinPara
FinAlgoritmo